
using System.Collections.Generic;

namespace StaffClockProject.Execution.Model {

    class User {

        public string Name { get; set; }
        public int Id { get; set; }
        public List<Event> Eventos { get; set; }

        public User(int id, string name) {

            this.Name = name;
            this.Id = id;
            this.Eventos = new List<Event>();

        }

    }

}
