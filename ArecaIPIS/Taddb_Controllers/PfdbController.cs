﻿using ArecaIPIS.Classes;
using ArecaIPIS.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArecaIPIS.Server_Classes
{
    class PfdbController
    {

        public static void PFDBsendData()
        {
            foreach (string ip in Server.PfdbIpAdress)
            {
                BaseClass.defectiveLines = OnlineTrainsDao.getDefectiveLines(ip);
                BaseClass.boardType = "PFDB";
                PacketController.DataPacket(ip);
                byte[] finalPacket = PfdbController.getTaddbFullPacket(Board.PFDB, Server.ipAdress, ip, BaseClass.GetSerialNumber(), Board.DataTransfer);
                string a = BaseClass.ByteArrayToString(finalPacket);
                if (BaseClass.Getinteroperabilitystatus(ip))
                    finalPacket = ByteFormation.RemoveFirstAndLast6(finalPacket);
                if (BaseClass.boardWorkingstatus && finalPacket.Length > 40)
                    Server.SendMessageToClient(ip, finalPacket);


            }
        }
      
       
        public static List<byte> finalDataPacket = new List<byte>();
        public static byte[] getTaddbFullPacket(int packetIdentifier, string SourceipAdress, string destinationIpAdress, int packetSerialNumer, int packetType)
        {
            try
            {


                finalDataPacket.Clear();

                finalDataPacket.AddRange(BaseClass.stratingBytes);//statrting bytes
                byte[] b1 = PacketController.firstPacketByte(packetIdentifier, SourceipAdress, destinationIpAdress, packetSerialNumer, packetType);

                byte[] b3 = BaseClass.taddbDataPacket.ToArray();


                finalDataPacket.AddRange(b1);
                finalDataPacket.AddRange(BaseClass.windowsDataPacket.ToArray());

                finalDataPacket.AddRange(PacketController.endingBytes);
                finalDataPacket.AddRange(b3);
                for (int i = 0; i < (PacketController.NormalWindows.Count); i++)
                {
                    int decimalValueOfCharctersting = PacketController.NormalWindows.Count * 14 + (2) + PacketController.NormalWindows[i];
                    byte[] characterStringIndices = BaseClass.ConvertDecimalNumberTOByteArray(decimalValueOfCharctersting);
                    finalDataPacket[5 + 12 + (i + 1) * 13 + i] = characterStringIndices[0];
                    finalDataPacket[5 + 12 + (i + 1) * 14] = characterStringIndices[1];
                }
                finalDataPacket.AddRange(PacketController.finalTaddbETX);
                finalDataPacket.AddRange(PacketController.stratingBytes);
                byte[] packetlengthbytes = BaseClass.ConvertDecimalNumberTOByteArray(finalDataPacket.Count - (6 + 5 + 1 + 6));
                finalDataPacket[9] = packetlengthbytes[0];
                finalDataPacket[10] = packetlengthbytes[1];
                byte[] crc = Server.CheckSum(finalDataPacket.ToArray());
                finalDataPacket[finalDataPacket.Count - 2 - 6 - 1] = crc[0];
                finalDataPacket[finalDataPacket.Count - 1 - 6 - 1] = crc[1];
                string a = BaseClass.ByteArrayToString(finalDataPacket.ToArray());
                return finalDataPacket.ToArray();
            }
            catch (Exception ex)
            {
                Server.LogError(ex.Message);
                return null;
            }

        }
        public static byte[] ConvertDecimalNumberTOByteArray(int decimalNumber)
        {       
            string hexString = decimalNumber.ToString("X4");          
            byte[] byteArray = new byte[2];            
            byteArray[0] = Convert.ToByte(hexString.Substring(0, 2), 16);
            byteArray[1] = Convert.ToByte(hexString.Substring(2, 2), 16);
            return byteArray;
        }
    }
}