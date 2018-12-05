using Microsoft.EntityFrameworkCore;
using StaffClockProject.Execution.Model;
using StaffClockProject.Properties;
using System.Data.Entity.Infrastructure;

namespace StaffClockProject.Execution.DAO {
    class StaffContext : DbContext {

        public DbSet<User> Users { get; private set; }
        public DbSet<Event> Eventos { get; private set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options) {

            string databaseIP = Settings.Default.DatabaseIP;
            options.UseSqlServer("Data Source=" + databaseIP + ";Initial Catalog=GECO;" +
                "User ID=conector;Password=bcf4ever");

        }

    }
}
