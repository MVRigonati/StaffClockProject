
using System.Collections.Generic;
using System.IO;

namespace StaffClockProject.Execution.Configurations {

    class UserListManager {

        public static Dictionary<string, string> LoadList(string path) {

            var userList = new Dictionary<string, string>();
            try {

                foreach (var lines in File.ReadAllLines(path)) {

                    string[] keyValuePair = lines.Split('§');
                    userList.Add(keyValuePair[0], keyValuePair[1]);

                }

            } catch (IOException) {
                return new Dictionary<string, string>();

            }
            return userList;

        }

        public static void SaveList(Dictionary<string, string> list, string path) {

            List<string> allUsers = new List<string>();
            foreach (KeyValuePair<string, string> keyValuePair in list) {
                allUsers.Add(keyValuePair.Key + "§" + keyValuePair.Value);
            }

            File.WriteAllLines(path, allUsers);

        }

    }

}
