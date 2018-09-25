
using System;

namespace StaffClockProject.Execution.Model {

    class Event {

        public DateTime Data { get; set; }

        public Event(int userID, DateTime data) {
            this.Data = data;
        }
        
    }

}
