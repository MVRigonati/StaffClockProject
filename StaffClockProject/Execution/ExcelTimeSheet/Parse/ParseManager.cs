
using StaffClockProject.Execution.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StaffClockProject.Execution.ExcelTimeSheet.Parse {

    class ParseManager {

        public static List<User> BuildUsers(string allEvents) {

            Dictionary<string, User> usersList = new Dictionary<string, User>();
            FillHashUsers(usersList);

            string[] allEventsArray = allEvents.Split(' ');
            foreach (string oneEvent in allEventsArray) {

                try {

                    var thisEvent = ParseEvent.CreateEvent(oneEvent, out string userID);
                    User user = usersList[userID];
                    user.Events.Add(thisEvent);

                } catch (ArgumentOutOfRangeException) {
                    // It's a genaric event

                } catch (KeyNotFoundException) {
                    // It's a genaric event

                }
                
            }

            return usersList.Values.ToList();
            
        }

        private static void FillHashUsers(Dictionary<string, User> usersList) {

            Dictionary<string, string> usersListDictionary = ConfigurationsMenu.Users;

            foreach (KeyValuePair<string, string> userList in usersListDictionary) {

                var user = new User(userList.Key, userList.Value);
                usersList.Add(user.Id, user);

            }

        }

    }
    
}
