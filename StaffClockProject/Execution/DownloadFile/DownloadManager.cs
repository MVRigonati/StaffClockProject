
using StaffClockProject.DownloadFile;
using StaffClockProject.Properties;
using System;

namespace StaffClockProject.Execution.ExcelTimeSheet.DownloadFile {

    class DownloadManager {

        public static void DownloadFileFrom(string ip, string user, string password) {

            var selenium = new DownloadTextSheet(
                ip, user, password, Settings.Default.PathToSave);

            var initialDateFormated = String.Format("{0:dd/MM/yy 00:01}", Settings.Default.InitialDate);
            var endDateFormated = String.Format("{0:dd/MM/yy 23:59}", Settings.Default.EndDate);

            int waitMinutes = Settings.Default.WaitMin * 1000;
            selenium.Download(initialDateFormated, endDateFormated, waitMinutes);

        }

    }
    
}
