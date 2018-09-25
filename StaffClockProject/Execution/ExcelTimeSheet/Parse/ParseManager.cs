
using StaffClockProject.Execution.Model;
using System.Collections;
using System.Collections.Generic;

namespace StaffClockProject.Execution.ExcelTimeSheet.Parse {

    class ParseManager {

        private static Hashtable usersList;

        public static Hashtable BuildUsersAndEvents(string allEvents) {
            
            usersList = new Hashtable();
            FillHashUsers();

            string[] allEventsArray = allEvents.Split(' ');
            foreach (string oneEvent in allEventsArray) {

                var thisEvent = ParseEvent.CreateEvent(null, out int userID);
                User user = (User) usersList[userID];
                user.Eventos.Add(thisEvent);

            }

            return usersList;
            
        }

        private static void FillHashUsers() {

            Dictionary<int, string> usersListDictionary = ConfigurationsMenu.Users;

            foreach (KeyValuePair<int, string> userList in usersListDictionary) {

                var user = new User(userList.Key, userList.Value);
                ParseManager.usersList.Add(user.Id, user);

            }

        }

    }
    
}
