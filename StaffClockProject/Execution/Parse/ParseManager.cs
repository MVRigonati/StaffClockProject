
using StaffClockProject.Execution.Model;
using System;
using System.Collections.Generic;

namespace StaffClockProject.Execution.ExcelTimeSheet.Parse {

    class ParseManager {

        public static List<Event> BuildEvents(string allEvents) {

            List<Event> eventsResult = new List<Event>();

            string[] allEventsArray = allEvents.Split(' ');
            foreach (string oneEvent in allEventsArray) {
                
                try {

                    var thisEvent = ParseEvent.CreateEvent(oneEvent);
                    eventsResult.Add(thisEvent);

                } catch (ArgumentOutOfRangeException) {
                    // It's a genaric event
                } catch (FormatException) {
                    // It's a genaric event
                }

            }

            return eventsResult;
            
        }

    }
    
}
