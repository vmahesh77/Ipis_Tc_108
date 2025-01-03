using ArecaIPIS.Classes;
using ArecaIPIS.DAL;
using NAudio.Wave;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArecaIPIS.Server_Classes
{
    class AnnouncementController
    {
        public static bool PauseButtonStatus = false;
        public static bool OtherAudioPlaying = false;
        private static ConcurrentDictionary<string, WaveOutEvent> activePlayers = new ConcurrentDictionary<string, WaveOutEvent>();
        private ConcurrentDictionary<string, AudioFileReader> activeAudioFiles = new ConcurrentDictionary<string, AudioFileReader>();
        private ManualResetEventSlim pauseEvent = new ManualResetEventSlim(true);
        private static bool isPaused = false;
        private List<string> audioPaths = new List<string>();
        public static CancellationTokenSource cts = new CancellationTokenSource();
        public static TaskCompletionSource<bool> pauseCompletionSource = new TaskCompletionSource<bool>();
        public static List<DataGridViewRow> AnnCheckedRows = new List<DataGridViewRow>();
        public static bool playStatus = true;
        //public static void playAnnounceMentData()
        //{




        //    BaseClass.AnnouncementDt = OnlineTrainsDao.GetScheduledAnnouncementTrains();



        //    List<string> selectedTrainNo = new List<string>();

        //    if (BaseClass.AnnouncementDt.Rows.Count == 0)
        //    {
        //        if (!BaseClass.IsNtesAudio() && !BaseClass.IsLocalAutoMode())
        //            MessageBox.Show("Please Select atleast One Train");
        //        return;
        //    }


        //    AnnouncementController.OtherAudioPlaying = true;
        //    isPaused = false;
        //    announce();


        //}
        public static void playAnnounceMentData()
        {




            BaseClass.AnnouncementDt = OnlineTrainsDao.GetScheduledAnnouncementTrains();



            List<string> selectedTrainNo = new List<string>();

            if (BaseClass.AnnouncementDt.Rows.Count == 0)
            {
                if (!BaseClass.IsNtesAudio() && !BaseClass.IsLocalAutoMode())
                    MessageBox.Show("Please Select atleast One Train");
                return;
            }

            bool status = DataController.CheckPlatformedrequiredexists(BaseClass.AnnouncementDt);
            if (!status)
            {


                AnnouncementController.OtherAudioPlaying = true;
                isPaused = false;
                announce();
            }


        }
        public static List<string> Selectedtrainno = new List<string>();
        public static String GetAnnounceMentTrainNumbers()
        {
            
            Selectedtrainno.Clear();
            string trainNumbers = "";
            try
            {


                foreach (DataRow row in BaseClass.AnnouncementDt.Rows)
                {
                    Selectedtrainno.Add(row["TrainNo"].ToString().Trim());
                    trainNumbers = trainNumbers + row["TrainNo"].ToString() + ",";

                }
            }
            catch (Exception ex)
            {
                Server.LogError(ex.Message);
            }

            return trainNumbers;

        }



        public void autoAnnounce()
        {
            try
            {


                DataTable AllTrain = OnlineTrainsDao.GetAllTrains();
                HashSet<string> validTrainNumbers = new HashSet<string>();
                foreach (DataRow row in AllTrain.Rows)
                {
                    string trainNumber = row["TrainNumber"].ToString();
                    validTrainNumbers.Add(trainNumber);
                }
                BaseClass.AnnouncementCount = 1;
                List<string> AllTrainNumbers = new List<string>();
                foreach (string trainNumber in Selectedtrainno)
                {
                    if (validTrainNumbers.Contains(trainNumber))
                    {
                        AllTrainNumbers.Add(trainNumber);
                    }
                }

                Selectedtrainno = AllTrainNumbers;

                announce();
            }
            catch (Exception ex)
            {
                Server.LogError(ex.Message);
            }

        }
        public static void PauseAllAudio()
        {
            try
            {


                isPaused = true;
                foreach (var player in activePlayers.Values)
                {
                    if (player.PlaybackState == PlaybackState.Playing)
                    {
                        player.Pause();
                    }
                }
                pauseCompletionSource = new TaskCompletionSource<bool>();
            }
            catch (Exception ex)
            {
                Server.LogError(ex.Message);
            }


        }

        public static void ResumeAllAudio()
        {
            try
            {


                isPaused = false;
                foreach (var player in activePlayers.Values)
                {
                    if (player.PlaybackState == PlaybackState.Paused)
                    {
                        player.Play();
                    }
                }
                pauseCompletionSource.SetResult(true);
            }
            catch (Exception ex)
            {
                Server.LogError(ex.Message);
            }


        }

        public static void StopAllAudio()
        {
            try
            {


                playStatus = true;
                if (cts != null)
                {
                    cts.Cancel();
                }

                foreach (var player in activePlayers.Values)
                {
                    player.Stop();
                }
                activePlayers.Clear();
            }
            catch (Exception ex)
            {
                Server.LogError(ex.Message);
            }

        }
        public static async Task PlayAudioSet(List<string> audioPaths, int playCount, CancellationToken token)
        {
            try
            {
                for (int count = 0; count < playCount; count++)
                {
                    foreach (string filePath in audioPaths)
                    {
                        token.ThrowIfCancellationRequested();

                        if (File.Exists(filePath))
                        {
                            await PlaySingleAudio(filePath, token);
                        }
                        else
                        {
                            //HandleAudioErrors(filePath);
                        }
                    }
                    await Task.Delay(100, token);
                }
                UpdateAudioPlayStatus("Completed");
            }
            catch
            {
            }

        }
        public static void UpdateAudioPlayStatus(string action)
        {
            try
            {
                bool successAction = OnlineTrainsDao.UpdateAudioPlayStatus(action);

                if (successAction)
                {
                    //MessageBox.Show("Audio play status updated successfully.");
                    AnnouncementController.OtherAudioPlaying = false;
                }
                else
                {
                    MessageBox.Show("No rows affected. Audio play status may not have been updated.");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating audio play status: {ex.Message}");
            }
        }
        public static async Task PlaySingleAudio(string filePath, CancellationToken token)
        {
            try
            {
                using (var audioFile = new AudioFileReader(filePath))
                {
                    var player = new WaveOutEvent();
                    activePlayers[filePath] = player;

                    player.Init(audioFile);
                    player.Play();

                    while (player.PlaybackState == PlaybackState.Playing)
                    {
                        await Task.Delay(100, token);
                        if (isPaused)
                        {
                            await pauseCompletionSource.Task;
                        }
                        token.ThrowIfCancellationRequested();
                    }
                    player.PlaybackStopped += (sender, args) =>
                    {
                        activePlayers.TryRemove(filePath, out _);
                    };
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
                //MessageBox.Show(ex.Message);
            }
        }
        public async static void announce()
        {
            try
            {


                string trainNo = GetAnnounceMentTrainNumbers();
                DataTable UpdatedFile = new DataTable();
                UpdatedFile.Columns.Add("LanguageID", typeof(int));
                UpdatedFile.Columns.Add("Sequence", typeof(int));
                UpdatedFile.Columns.Add("AudioFile", typeof(string));

                foreach (string trainNumber in Selectedtrainno)
                {
                    var data = OnlineTrainsDao.SendToAnnouncement(trainNumber);
                    int newseq = 1;

                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        var fileName = data.Rows[i]["AudioName"].ToString();
                        var LanguageID = data.Rows[i]["LanguageId"].ToString();
                        var sequence = data.Rows[i]["sequence"].ToString();
                        var AudioPath = data.Rows[i]["AudioPath"].ToString();
                        var TrainNo = data.Rows[i]["TrainNo"].ToString();
                        var RAH = Convert.ToInt32(data.Rows[i]["RArrivalTime"].ToString().Split(':')[0]);
                        var RAM = Convert.ToInt32(data.Rows[i]["RArrivalTime"].ToString().Split(':')[1]);
                        var RDH = Convert.ToInt32(data.Rows[i]["RDepartureTime"].ToString().Split(':')[0]);
                        var RDM = Convert.ToInt32(data.Rows[i]["RDepartureTime"].ToString().Split(':')[1]);
                        var LAH = Convert.ToInt32(data.Rows[i]["LArrivalTime"].ToString().Split(':')[0]);
                        var LAM = Convert.ToInt32(data.Rows[i]["LArrivalTime"].ToString().Split(':')[1]);
                        var LDTH = Convert.ToInt32(data.Rows[i]["LDepartureTime"].ToString().Split(':')[0]);
                        var LDTM = Convert.ToInt32(data.Rows[i]["LDepartureTime"].ToString().Split(':')[1]);
                        var LATEH = Convert.ToInt32(data.Rows[i]["LateBy"].ToString().Split(':')[0]);
                        var LATEM = Convert.ToInt32(data.Rows[i]["LateBy"].ToString().Split(':')[1]);
                        var StatusName = data.Rows[i]["StatusName"].ToString();
                        var PFNO = data.Rows[i]["PFNO"].ToString();

                        string[] TrainNoaudiopath = new string[5];
                        string pathstr = "";
                        string PathTrainnamestr = "";
                        //var Traintype = OnlineTrainsDao.GetTrainUpDownStatus(TrainNo);
                        //string TrainTypestatus = Traintype.Rows[0]["TrainType"].ToString();
                        string TrainNamestr = "";


                        if (fileName.ToLower() == "train number")
                        {

                            if (LanguageID == "1")
                            {
                                pathstr = "E:\\Audio\\English\\Numbers\\";
                            }
                            else if (LanguageID == "2")
                            {
                                pathstr = "E:\\Audio\\Hindi\\Numbers\\";
                            }
                            else if (LanguageID == "3")
                            {
                                pathstr = "E:\\Audio\\Local\\Numbers\\";
                            }
                            for (int j = 0; j < TrainNo.Length; j++)
                            {
                                TrainNoaudiopath[j] = pathstr + TrainNo[j] + ".wav";
                            }
                            //}

                            if (LanguageID == "1")
                            {
                                PathTrainnamestr = "E:\\Audio\\English\\TrainNames\\";
                            }
                            else if (LanguageID == "2")
                            {
                                PathTrainnamestr = "E:\\Audio\\Hindi\\TrainNames\\";
                            }
                            else if (LanguageID == "3")
                            {
                                PathTrainnamestr = "E:\\Audio\\Local\\TrainNames\\";
                            }

                            TrainNamestr = PathTrainnamestr + TrainNo + ".wav";

                        }


                        var Diverted = data.Rows[i]["StationCode"].ToString();

                        if (StatusName.ToLower() == "diverted")
                        {
                            string[] tokens = Diverted.Split(',');
                            if (fileName.ToLower() == "stn0")
                            {
                                AudioPath = AudioPath.Replace("{0}", tokens[0]);
                            }
                            else if (fileName.ToLower() == "stn1" && (tokens.Length == 2 || tokens.Length == 3))
                            {
                                AudioPath = AudioPath.Replace("{1}", tokens[1]);
                            }
                            else if (fileName.ToLower() == "stn2" && tokens.Length == 3)
                            {
                                AudioPath = AudioPath.Replace("{2}", tokens[2]);
                            }

                        }
                        if (StatusName.ToLower() == "change of source")
                        {
                            if (fileName.ToLower() == "stn")
                            {
                                AudioPath = AudioPath.Replace("{0}", Diverted);
                            }
                        }
                        if (StatusName.ToLower() == "terminated")
                        {
                            if (fileName.ToLower() == "stn")
                            {
                                AudioPath = AudioPath.Replace("{0}", Diverted);
                            }
                        }
                        if (StatusName.ToLower() == "terminated at")
                        {
                            if (fileName.ToLower() == "stn")
                            {
                                AudioPath = AudioPath.Replace("{0}", Diverted);
                            }
                        }
                        if (fileName.ToLower() == "stah hours" && LanguageID == "3" && RAH == 1 && RAM != 0)
                        {

                            AudioPath = "E:\\Audio\\Local\\StatusMessages\\Hour_T.wav";

                        }

                        else if (fileName.ToLower() == "stdh hours" && LanguageID == "3" && RAH == 1 && RAM != 0)
                        {

                            AudioPath = "E:\\Audio\\Local\\StatusMessages\\Hour_T.wav";

                        }
                        else if (fileName.ToLower() == "etah hours" && LanguageID == "3" && LAH == 1 && LAM != 0)
                        {

                            AudioPath = "E:\\Audio\\Local\\StatusMessages\\Hour_T.wav";

                        }
                        else if (fileName.ToLower() == "etdh hours" && LanguageID == "3" && LDTH == 1 && LDTH != 0)
                        {
                            AudioPath = "E:\\Audio\\Local\\StatusMessages\\Hour_T.wav";

                        }

                        else if (fileName.ToLower() == "stah hours" && LanguageID == "1" && RAH == 1 && RAM != 0)
                        {
                            AudioPath = "E:\\Audio\\English\\StatusMessages\\Hour.wav";

                        }
                        else if (fileName.ToLower() == "stdh hours" && LanguageID == "1" && RDH == 1 && RDM != 0)
                        {
                            AudioPath = "E:\\Audio\\English\\StatusMessages\\Hour.wav";
                        }
                        else if (fileName.ToLower() == "etah hours" && LanguageID == "1" && LAH == 1 && LAM != 0)
                        {
                            AudioPath = "E:\\Audio\\English\\StatusMessages\\Hour.wav";
                        }
                        else if (fileName.ToLower() == "etdh hours" && LanguageID == "1" && LDTH == 1 && LDTM != 0)
                        {
                            AudioPath = "E:\\Audio\\English\\StatusMessages\\Hour.wav";
                        }


                        else if (fileName.ToLower() == "stah hours" && LanguageID == "1" && RAH != 0 && RAM == 0)
                        {
                            if (RAH == 1)
                            {
                                AudioPath = "E:\\Audio\\English\\StatusMessages\\Hour.wav";
                            }
                            else
                            {
                                AudioPath = "E:\\Audio\\English\\StatusMessages\\Hours.wav";
                            }
                        }
                        else if (fileName.ToLower() == "stah hours" && LanguageID == "2" && RAH != 0 && RAM == 0)
                        {
                            if (RAH >= 1)
                            {
                                AudioPath = "E:\\Audio\\Hindi\\StatusMessages\\Hour_H.wav";
                            }
                            else
                            {
                                AudioPath = "E:\\Audio\\Hindi\\StatusMessages\\Hours_H.wav";
                            }
                        }
                        else if (fileName.ToLower() == "stah hours" && LanguageID == "3" && RAH != 0 && RAM == 0)
                        {
                            if (RAH == 1)
                            {
                                AudioPath = "E:\\Audio\\Local\\StatusMessages\\Hour_T.wav";
                            }
                            else
                            {
                                AudioPath = "E:\\Audio\\Local\\StatusMessages\\Gantalaku_T.wav";
                            }
                        }
                        else if (fileName.ToLower() == "stam minutes" && LanguageID == "3" && RAH == 0 && RAM != 0)
                        {
                            AudioPath = "E:\\Audio\\Local\\StatusMessages\\Minutes Ku_T.wav";
                        }
                        else if (fileName.ToLower() == "stam minutes" && (LanguageID == "1" || LanguageID == "2" || LanguageID == "3") && RAM == 0)
                        {
                            AudioPath = "";
                        }




                        else if (fileName.ToLower() == "stdh hours" && LanguageID == "1" && RDH != 0 && RDM == 0)
                        {
                            if (RDH == 1)
                            {
                                AudioPath = "E:\\Audio\\English\\StatusMessages\\Hour.wav";
                            }
                            else
                            {
                                AudioPath = "E:\\Audio\\English\\StatusMessages\\Hours.wav";
                            }
                        }
                        else if (fileName.ToLower() == "stdh hours" && LanguageID == "2" && RDH != 0 && RDM == 0)
                        {
                            if (RDH >= 1)
                            {
                                AudioPath = "E:\\Audio\\Hindi\\StatusMessages\\Hour_H.wav";
                            }
                            else
                            {
                                AudioPath = "E:\\Audio\\Hindi\\StatusMessages\\Hours_H.wav";
                            }
                        }

                        else if (fileName.ToLower() == "stdh hours" && LanguageID == "3" && RDH != 0 && RDM == 0)
                        {
                            if (RDH == 1)
                            {
                                AudioPath = "E:\\Audio\\Local\\StatusMessages\\Hour_T.wav";
                            }
                            else
                            {
                                AudioPath = "E:\\Audio\\Local\\StatusMessages\\Gantalaku_T.wav";
                            }
                        }
                        else if (fileName.ToLower() == "stdm minutes" && LanguageID == "3" && RDH == 0 && RDM != 0)
                        {
                            AudioPath = "E:\\Audio\\Local\\StatusMessages\\Minutes Ku_T.wav";
                        }
                        else if (fileName.ToLower() == "stdm minutes" && (LanguageID == "1" || LanguageID == "2" || LanguageID == "3") && RDM == 0)
                        {
                            AudioPath = "";
                        }



                        else if (fileName.ToLower() == "etah hours" && LanguageID == "1" && LAH != 0 && LAM == 0)
                        {
                            if (LAH == 1)
                            {
                                AudioPath = "E:\\Audio\\English\\StatusMessages\\Hour.wav";
                            }
                            else
                            {
                                AudioPath = "E:\\Audio\\English\\StatusMessages\\Hours.wav";
                            }
                        }
                        else if (fileName.ToLower() == "etah hours" && LanguageID == "2" && LAH != 0 && LAM == 0)
                        {
                            if (LAH >= 1)
                            {
                                AudioPath = "E:\\Audio\\Hindi\\StatusMessages\\Hour_H.wav";
                            }
                            else
                            {
                                AudioPath = "E:\\Audio\\Hindi\\StatusMessages\\Hours_H.wav";
                            }
                        }

                        else if (fileName.ToLower() == "etah hours" && LanguageID == "3" && LAH != 0 && LAM == 0)
                        {
                            if (LAH == 1)
                            {
                                AudioPath = "E:\\Audio\\Local\\StatusMessages\\Gantaku_T.wav";
                            }
                            else
                            {
                                AudioPath = "E:\\Audio\\Local\\StatusMessages\\Gantalaku_T.wav";
                            }
                        }
                        else if (fileName.ToLower() == "etah hours" && LanguageID == "3" && LAH == 1 && LAM != 0)
                        {
                            AudioPath = "E:\\Audio\\Local\\StatusMessages\\Hour_T.wav";
                        }
                        else if (fileName.ToLower() == "etam minutes" && LanguageID == "3" && LAH == 0 && LAM != 0)
                        {
                            AudioPath = "E:\\Audio\\Local\\StatusMessages\\Minutes Ku_T.wav";
                        }
                        else if (fileName.ToLower() == "etam minutes" && (LanguageID == "1" || LanguageID == "2" || LanguageID == "3") && LAM == 0)
                        {
                            AudioPath = "";
                        }


                        else if (fileName.ToLower() == "etdh hours" && LanguageID == "1" && LDTH != 0 && LDTM == 0)
                        {
                            if (LDTH == 1)
                            {
                                AudioPath = "E:\\Audio\\English\\StatusMessages\\Hour.wav";
                            }
                            else
                            {
                                AudioPath = "E:\\Audio\\English\\StatusMessages\\Hours.wav";
                            }
                        }
                        else if (fileName.ToLower() == "etdh hours" && LanguageID == "2" && LDTH != 0 && LDTM == 0)
                        {
                            if (LDTH >= 1)
                            {
                                AudioPath = "E:\\Audio\\Hindi\\StatusMessages\\Hour_H.wav";
                            }
                            else
                            {
                                AudioPath = "E:\\Audio\\Hindi\\StatusMessages\\Hours_H.wav";
                            }
                        }

                        else if (fileName.ToLower() == "etdh hours" && LanguageID == "3" && LDTH != 0 && LDTM == 0)
                        {
                            if (RDH == 1)
                            {
                                AudioPath = "E:\\Audio\\Local\\StatusMessages\\Gantaku.wav";
                            }
                            else
                            {
                                AudioPath = "E:\\Audio\\Local\\StatusMessages\\Gantalaku_T.wav";
                            }
                        }
                        else if (fileName.ToLower() == "etdm minutes" && LanguageID == "3" && LDTH == 0 && LDTM != 0)
                        {
                            AudioPath = "E:\\Audio\\Local\\StatusMessages\\Minutes Ku_T.wav";
                        }
                        else if (fileName.ToLower() == "etam minutes" && (LanguageID == "1" || LanguageID == "2" || LanguageID == "3") && LAM == 0)
                        {
                            AudioPath = "";
                        }



                        else if (fileName.ToLower() == "lateh hours" && LanguageID == "1" && LATEH != 0 && LATEM == 0)
                        {
                            if (LATEH == 1)
                            {
                                AudioPath = "E:\\Audio\\English\\StatusMessages\\Hour.wav";
                            }
                            else
                            {
                                AudioPath = "E:\\Audio\\English\\StatusMessages\\Hours.wav";
                            }
                        }
                        else if (fileName.ToLower() == "lateh hours" && LanguageID == "2" && LATEH != 0 && LATEM == 0)
                        {

                            AudioPath = "E:\\Audio\\Hindi\\StatusMessages\\Ganta_H.wav";

                        }

                        else if (fileName.ToLower() == "lateh hours" && LanguageID == "3" && LATEH != 0 && LATEM == 0)
                        {
                            if (LATEH == 1)
                            {
                                AudioPath = "E:\\Audio\\Local\\StatusMessages\\Ganta_T.wav";
                            }
                            else
                            {
                                AudioPath = "E:\\Audio\\Local\\StatusMessages\\Gantalu_T.wav";
                            }
                        }

                        else if (fileName.ToLower() == "lateh hours" && LanguageID == "1" && LATEH == 1 && LATEM != 0)
                        {

                            AudioPath = "E:\\Audio\\English\\StatusMessages\\Hour.wav";
                        }

                        else if (fileName.ToLower() == "lateh hours" && LanguageID == "3" && LATEH == 1 && LATEM != 0)
                        {

                            AudioPath = "E:\\Audio\\Local\\StatusMessages\\Ganta_T.wav";
                        }




                        else if (fileName.ToLower() == "latem minutes" && LanguageID == "3" && (LATEH == 0 || LATEH == 1) && LATEM != 0)
                        {
                            if (LATEM == 1)
                            {
                                AudioPath = "E:\\Audio\\Local\\StatusMessages\\Minute_T.wav";
                            }
                            else
                            {
                                AudioPath = "E:\\Audio\\Local\\StatusMessages\\Minutes_T.wav";
                            }


                        }

                        else if (fileName.ToLower() == "latem minutes" && (LanguageID == "1" || LanguageID == "2" || LanguageID == "3") && LATEM == 0)
                        {
                            AudioPath = "";
                        }


                        else if (fileName.ToLower() == "stah" && RAH != 0)
                        {
                            AudioPath = AudioPath.Replace("{0}", Convert.ToString(RAH));
                        }
                        else if (fileName.ToLower() == "stah" && RAH == 0)
                        {
                            AudioPath = "";
                        }

                        else if (fileName.ToLower() == "stah hours" && RAH == 0)
                        {
                            AudioPath = "";
                        }

                        else if (fileName.ToLower() == "stam" && RAM != 0)
                        {
                            AudioPath = AudioPath.Replace("{0}", Convert.ToString(RAM));
                        }
                        else if (fileName.ToLower() == "stam" && RAM == 0)
                        {
                            AudioPath = "";
                        }
                        else if (fileName.ToLower() == "stam minutes" && RAM == 0)
                        {
                            AudioPath = "";
                        }


                        else if (fileName.ToLower() == "lateh" && LATEH != 0)
                        {
                            AudioPath = AudioPath.Replace("{0}", Convert.ToString(LATEH));
                        }
                        else if (fileName.ToLower() == "lateh" && LATEH == 0)
                        {
                            AudioPath = "";
                        }
                        else if (fileName.ToLower() == "lateh hours" && LATEH == 0)
                        {
                            AudioPath = "";
                        }

                        else if (fileName.ToLower() == "latem" && LATEM != 0)
                        {
                            AudioPath = AudioPath.Replace("{0}", Convert.ToString(LATEM));
                        }
                        else if (fileName.ToLower() == "latem" && LATEM == 0)
                        {
                            AudioPath = "";
                        }
                        else if (fileName.ToLower() == "latem minutes" && LATEM == 0)
                        {
                            AudioPath = "";
                        }


                        else if (fileName.ToLower() == "etah" && LAH != 0)
                        {
                            AudioPath = AudioPath.Replace("{0}", Convert.ToString(LAH));
                        }
                        else if (fileName.ToLower() == "etah" && LAH == 0)
                        {
                            AudioPath = "";
                        }

                        else if (fileName.ToLower() == "etam" && LAM != 0)
                        {

                            AudioPath = AudioPath.Replace("{0}", Convert.ToString(LAM));
                        }
                        else if (fileName.ToLower() == "etam")
                        {
                            AudioPath = "";
                        }
                        else if (fileName.ToLower() == "etdh" && LDTH != 0)
                        {
                            AudioPath = AudioPath.Replace("{0}", Convert.ToString(LDTH));
                        }
                        else if (fileName.ToLower() == "etdh" && LDTH == 0)
                        {
                            AudioPath = "";
                        }
                        else if (fileName.ToLower() == "etdm" && LDTM != 0)
                        {
                            AudioPath = AudioPath.Replace("{0}", Convert.ToString(LDTM));
                        }
                        else if (fileName.ToLower() == "etdm" && LDTM == 0)
                        {
                            AudioPath = "";
                        }
                        else if (fileName.ToLower() == "stdh" && RDH != 0)
                        {
                            AudioPath = AudioPath.Replace("{0}", Convert.ToString(RDH));
                        }
                        else if (fileName.ToLower() == "stdh" && RDH == 0)
                        {
                            AudioPath = "";
                        }

                        else if (fileName.ToLower() == "stdm" && RDM != 0)
                        {
                            AudioPath = AudioPath.Replace("{0}", Convert.ToString(RDM));
                        }
                        else if (fileName.ToLower() == "stdm" && RDM == 0)
                        {
                            AudioPath = "";
                        }
                        else if (fileName.ToLower() == "etdm minutes" && LDTM == 0)
                        {
                            AudioPath = "";
                        }
                        else if (fileName.ToLower() == "etdh hours" && LDTH == 0)
                        {
                            AudioPath = "";
                        }
                        else if (fileName.ToLower() == "stdh hours" && RDH == 0)
                        {
                            AudioPath = "";
                        }
                        else if (fileName.ToLower() == "stdm minutes" && RDM == 0)
                        {
                            AudioPath = "";
                        }
                        else if (fileName.ToLower() == "stah hours" && RAH == 0)
                        {
                            AudioPath = "";
                        }
                        else if (fileName.ToLower() == "stam minutes" && RAM == 0)
                        {
                            AudioPath = "";
                        }
                        else if (fileName.ToLower() == "etah hours" && LAH == 0)
                        {
                            AudioPath = "";
                        }
                        else if (fileName.ToLower() == "etah hours" && LAH == 1 && LanguageID == "1")
                        {

                            AudioPath = "E:\\Audio\\English\\StatusMessages\\Hour.wav";
                        }
                        else if (fileName.ToLower() == "lateh hours" && LAH == 1 && LanguageID == "2")
                        {
                            AudioPath = "E:\\Audio\\Hindi\\StatusMessages\\Ganta_H.wav";
                        }
                        else if (fileName.ToLower() == "lateh hours" && LAH == 1 && LanguageID == "3")
                        {
                            AudioPath = "E:\\Audio\\Local\\StatusMessages\\Ganta_T.wav";
                        }

                        else if (fileName.ToLower() == "etam minutes" && LAM == 0)
                        {
                            AudioPath = "";
                        }
                        else if (fileName.ToLower() == "etdm minutes" && LDTM == 0)
                        {
                            AudioPath = "";
                        }
                        else if (fileName.ToLower() == "etdh hours" && LDTH == 0)
                        {
                            AudioPath = "";
                        }

                        else if (fileName.ToLower() == "hours")
                        {
                            AudioPath = AudioPath.Replace("{0}", Convert.ToString(RAH));
                        }

                        else if (fileName.ToLower() == "minutes")
                        {
                            AudioPath = AudioPath.Replace("{0}", Convert.ToString(RAM));
                        }

                        else if (fileName.ToLower() == "platform number")
                        {
                            if (PFNO != null)
                            {
                                AudioPath = AudioPath.Replace("{0}", PFNO);
                            }
                        }

                        else if (fileName.ToLower() == "late hrs" || fileName.ToLower() == "l hr")
                        {
                            AudioPath = AudioPath.Replace("{0}", Convert.ToString(LAH));
                        }

                        else if (fileName.ToLower() == "late minutes" || fileName.ToLower() == "late min")
                        {
                            AudioPath = AudioPath.Replace("{0}", Convert.ToString(LAM));
                        }
                        else if (fileName.ToLower() == "{scadh}" || fileName.ToLower() == "scadh")
                        {
                            AudioPath = AudioPath.Replace("{0}", Convert.ToString(RDH));
                        }
                        else if (fileName.ToLower() == "{scadm}")
                        {
                            AudioPath = AudioPath.Replace("{0}", Convert.ToString(RDM));
                        }
                        else if (fileName.ToLower() == "{schadm}")
                        {
                            AudioPath = AudioPath.Replace("{0}", Convert.ToString(LDTM));
                        }
                        else if (fileName.ToLower() == "{schadh}")
                        {
                            AudioPath = AudioPath.Replace("{0}", Convert.ToString(LDTH));
                        }



                        if (AudioPath.IndexOf("{1}") > -1 || AudioPath.IndexOf("{2}") > -1 || AudioPath.IndexOf("{3}") > -1 || AudioPath == "")
                        {
                        }
                        else
                            if (fileName.ToLower() == "train number")
                        {
                            for (int c = 0; c < TrainNoaudiopath.Length; c++)
                            {
                                UpdatedFile.Rows.Add(Convert.ToInt32(LanguageID), newseq, TrainNoaudiopath[c]);
                                newseq++;

                            }
                            UpdatedFile.Rows.Add(Convert.ToInt32(LanguageID), newseq, TrainNamestr);
                            newseq++;

                        }

                        else
                        {
                            UpdatedFile.Rows.Add(Convert.ToInt32(LanguageID), newseq, AudioPath);

                            newseq = newseq + 1;
                        }
                    }

                }

                if (UpdatedFile.Rows.Count > 0)
                {

                    DataTable dt = OnlineTrainsDao.PlayAnnouncemnet(UpdatedFile, BaseClass.AnnouncementCount, trainNo);

                    if (dt.Rows.Count > 0)
                    {

                        string statusMessage = dt.Rows[0]["Alert"].ToString();
                        if (statusMessage.Contains("Audio play started"))
                        {
                            string logFilePath = "C:\\ShareToAll\\Announcement.txt";
                            Directory.CreateDirectory(Path.GetDirectoryName(logFilePath));

                            using (StreamWriter sw = new StreamWriter(logFilePath))
                            {
                                foreach (DataRow row in UpdatedFile.Rows)
                                {
                                    sw.WriteLine(row["AudioFile"].ToString());
                                }
                            }
                            cts = new CancellationTokenSource();
                            //List<string> audioPaths = UpdatedFile.AsEnumerable().Select(r => r.Field<string>("AudioFile")).ToList();
                            List<string> audioPaths = UpdatedFile.AsEnumerable()
    .Select(r => r.Field<string>("AudioFile")
        .Replace("\r\n", "")
        .Replace("\n", "")  // Optional, if newlines without carriage return are also present
        .Replace("\r", ""))  // Optional, if carriage returns alone are present
    .ToList();

                            await PlayAudioSet(audioPaths, BaseClass.AnnouncementCount, cts.Token);
                        }
                        else if (statusMessage.Contains("Other audio is Playing"))
                        {
                            MessageBox.Show("Other audio is playing.");
                        }
                        else
                        {
                            MessageBox.Show("Unexpected status: " + statusMessage);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No status information returned.");
                    }

                    //cts = new CancellationTokenSource();
                    //IEnumerable<DataRow> rows = UpdatedFile.AsEnumerable();
                    //IEnumerable<string> audioFileValues = rows.Select(r => r.Field<string>("AudioFile"));
                    //List<string> audioPaths = audioFileValues.ToList();
                    //await PlayAudioSet(audioPaths, nupMessageValue, cts.Token);

                }
                else
                {
                    if (!BaseClass.IsNtesAudio() || !BaseClass.IsLocalAutoMode())
                        MessageBox.Show("No valid audio files found to update.");
                }
            }
            catch (Exception ex)
            {
                Server.LogError(ex.Message);
            }

        }

        public static void CheckPauseButtonClick()
        {
            if (AnnouncementController.PauseButtonStatus)
            {
                AnnouncementController.PauseButtonStatus = false;
            }
            else
            {
                AnnouncementController.PauseButtonStatus = true;
            }
        }
        public static void UpdateStatus(string action)
        {
            try
            {
                DataTable status = OnlineTrainsDao.getUpdatedStatus(action);

                if (status != null && status.Rows.Count > 0)
                {
                    string alertValue = status.Rows[0]["ALERT"].ToString();

                    if ((alertValue == "RESUME") || (alertValue == "PAUSE"))
                    {
                        PauseAudio(alertValue);
                    }
                    else if (alertValue == "STOP")
                    {
                        StopAllAudio();
                    }
                    else if (alertValue == "INSERTED")
                    {
                      //  MessageBox.Show("Handling action: " + alertValue);

                    }
                    else
                    {
                        MessageBox.Show("Unknown action: " + alertValue);
                    }
                }
                else
                {
                    MessageBox.Show("No data returned from database for action: " + action);
                }
            }
            catch (Exception ex)
            {
                Server.LogError(ex.Message);
            }


        }
        public static void PauseAudio(string alertValue)
        {
            try
            {


                if (alertValue == "PAUSE")
                {
                    ResumeAllAudio();
                    if (BaseClass.btnPause != null)
                    {
                        string lowerCaseAlertValue = alertValue.ToLower();

                        string formattedAlertValue = char.ToUpper(lowerCaseAlertValue[0]) + lowerCaseAlertValue.Substring(1);

                        BaseClass.btnPause = formattedAlertValue;
                    }
                }
                else
                {
                    PauseAllAudio();
                    if (BaseClass.btnPause != null)
                    {
                        string lowerCaseAlertValue = alertValue.ToLower();

                        string formattedAlertValue = char.ToUpper(lowerCaseAlertValue[0]) + lowerCaseAlertValue.Substring(1);

                        BaseClass.btnPause = formattedAlertValue;
                    }
                }
            }
            catch (Exception ex)
            {
                Server.LogError(ex.Message);
            }

        }
    }
}
