using ArecaIPIS.Classes;
using ArecaIPIS.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArecaIPIS.Server_Classes
{
    class IvdOvdController
    {



        public static void OVDsendData()
        {

            foreach (string ip in Server.OvdIpAdress)
            {
                BaseClass.defectiveLines = OnlineTrainsDao.getDefectiveLines(ip);
                BaseClass.boardType = "OvdIvd";
                PacketController.DataPacket(ip);
                byte[] finalPacket = IvdOvdController.getIvdOvdFullPacket(Board.OVD, Server.ipAdress, ip, BaseClass.GetSerialNumber(), Board.DataTransfer);
                string a = BaseClass.ByteArrayToString(finalPacket);
                if (BaseClass.boardWorkingstatus && finalPacket.Length > 40)
                    Server.SendMessageToClient(ip, finalPacket);

            }
        }


        

        public static void IVDsendData()
        {
            foreach (string ip in Server.IvdIpAdress)
            {
                BaseClass.defectiveLines = OnlineTrainsDao.getDefectiveLines(ip);
                BaseClass.boardType = "OvdIvd";
                PacketController.DataPacket(ip);
                byte[] finalPacket = IvdOvdController.getIvdOvdFullPacket(Board.OVD, Server.ipAdress, ip, BaseClass.GetSerialNumber(), Board.DataTransfer);
                if (BaseClass.boardWorkingstatus && finalPacket.Length > 40)
                    Server.SendMessageToClient(ip, finalPacket);
            }
        }


        public static List<byte> finalDataPacket = new List<byte>();
        public static byte[] getIvdOvdFullPacket(int packetIdentifier, string SourceipAdress, string destinationIpAdress, int packetSerialNumer, int packetType)
        {
            try
            {


                finalDataPacket.Clear();
                finalDataPacket.AddRange(BaseClass.stratingBytes);//statrting bytes
                byte[] b1 = PacketController.firstPacketByte(packetIdentifier, SourceipAdress, destinationIpAdress, packetSerialNumer, packetType);
                byte[] b3 = BaseClass.taddbDataPacket.ToArray();
                finalDataPacket.AddRange(b1);
                PrepareOVDIVDWindowsDataPacket();
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
                return null;
                Server.LogError(ex.Message);
            }

        }

        public static void PrepareOVDIVDWindowsDataPacket()
        {
            try
            {
                

                BaseClass.CurrentStatuCode =-1;
                BaseClass.windowsDataPacket.Clear();

                int window = BaseClass.OnlineTrainsTaddbDt.Rows.Count / BaseClass.noOfLines;

                if (BaseClass.OnlineTrainsTaddbDt.Rows.Count % BaseClass.noOfLines != 0)
                {
                    window = window + 1;
                }

                int noOfLines = window * BaseClass.noOfLines * BaseClass.languageSequencepk.Count;


                for (int i = 0; i < noOfLines; i++)
                {
                    BaseClass.windowsDataPacket.AddRange(PacketController.ovdIvdWindows());
                }
            }
            catch (Exception ex)
            {
                Server.LogError(ex.Message);
            }

        }
    }
}
