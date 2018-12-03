using Microsoft.EntityFrameworkCore;
using StaffClockProject.Execution.Model;

namespace StaffClockProject.Execution.DAO {
    class StaffContext : DbContext {

        public DbSet<User> Users { get; private set; }
        public DbSet<Event> Eventos { get; private set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) {
            options.UseSqlServer("Data Source=192.168.1.213;Initial Catalog=GECO;" +
                "User ID=conector;Password=bcf4ever");
        }

    }
}
