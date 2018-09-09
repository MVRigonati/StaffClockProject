
using System.Net;
using String = System.String;

namespace StaffClockProject.DownloadFile {

    class DownloadTextSheet {

        public String Download(String url) {

            var client = new WebClient();
            return client.DownloadString(url);

        }

        public String Download(String url, String user, String password) {

            var client = new WebClient();
            client.Credentials = new NetworkCredential(user, password);
            return client.DownloadString(url);

        }

    }

}
