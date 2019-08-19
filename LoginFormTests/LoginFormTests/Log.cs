using System;
using System.IO;
using System.Linq;

namespace LoginFormTests
{
    class Log
    {
        public static string logDir = "C:\\Users\\" + Environment.UserName + "\\AppData\\Roaming\\LoginFormTests";
        public static string logPath = "C:\\Users\\" + Environment.UserName +
                                       String.Format("\\AppData\\Roaming\\LoginFormTests\\{0}.log", DateTime.Today.ToString("dd.MM.yyyy"));

        // Check log directory and log files existence
        public static void CheckLogsExistence()
        {

            DirectoryInfo logDirectory = new DirectoryInfo(logDir);

            if (!logDirectory.Exists)
            {
                logDirectory.Create();
            }
            else
            {
                var logFilesQuantity = logDirectory.GetFiles().Length;
                if (logFilesQuantity >= 30)
                {
                    var firstCreatedLogFile =
                        (from f in logDirectory.GetFiles() orderby f.LastWriteTime descending select f).Last();
                    File.Delete(firstCreatedLogFile.Name);
                }
            }

            if (!File.Exists(logPath))
            {
                using (StreamWriter sw = new StreamWriter(new FileStream(logPath, FileMode.Append, FileAccess.Write)))
                {
                    sw.WriteLine("Start - {0}", DateTime.Now);
                }
            }
            else
            {
                // Check log file creating date
                DateTime dt = DateTime.Today;
                DateTime currLogDt = File.GetLastAccessTime(logPath).Date;
                var lastCreatedLogFile =
                    (from f in logDirectory.GetFiles() orderby f.LastWriteTime descending select f).First();
                if (currLogDt < dt)
                {
                    File.Move(logDir + "/" + lastCreatedLogFile.Name, logDir + "/" + lastCreatedLogFile.LastWriteTime.ToString().Replace(".", "-").Replace(":", "-").Replace(" ", "_") + ".log");
                }
            }
        }

        public static void WriteLog(string dataForLog)
        {
            CheckLogsExistence();
            using (StreamWriter sw = new StreamWriter(new FileStream(logPath, FileMode.Append, FileAccess.Write)))
            {
                sw.WriteLine("[{0}]: {1}", DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss"), dataForLog);
            }
        }
    }
}
