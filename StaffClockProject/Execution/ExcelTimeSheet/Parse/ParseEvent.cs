
using StaffClockProject.Execution.Model;
using System;

namespace StaffClockProject.Execution.ExcelTimeSheet.Parse {

    class ParseEvent {
        
        public static Event CreateEvent(string oneEvent, out string userID) {

            userID = oneEvent.Substring(22, 12);

            string day = oneEvent.Substring(10, 2);
            string month = oneEvent.Substring(12, 2);
            string year = oneEvent.Substring(14, 4);
            string hour = oneEvent.Substring(18, 2);
            string minute = oneEvent.Substring(20, 2);

            DateTime dataEvento = new DateTime();
            try {
                dataEvento = new DateTime(
                    Convert.ToInt32(year),
                    Convert.ToInt32(month),
                    Convert.ToInt32(day),
                    Convert.ToInt32(hour),
                    Convert.ToInt32(minute),
                    0);
            } catch (FormatException) {

            }

            return new Event(dataEvento);

        }

    }

}
