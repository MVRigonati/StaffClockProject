
using StaffClockProject.Execution.Model;

namespace StaffClockProject.Execution.DAO {
    class EventDAO {

        public void PersistEvent(Event oneEvent) {

            var context = new StaffContext();
            context.Eventos.Add(oneEvent);
            context.SaveChanges();

        }

    }
}
