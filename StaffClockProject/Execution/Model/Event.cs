
using System;
using System.ComponentModel.DataAnnotations;

namespace StaffClockProject.Execution.Model {

    class Event {

        [Key]
        public string UserID { get; set; }

        public DateTime DataEvento { get; set; }

        public Event(string userId, DateTime dataEvento) {
            this.UserID = userId;
            this.DataEvento = dataEvento;
        }
        
    }

}
