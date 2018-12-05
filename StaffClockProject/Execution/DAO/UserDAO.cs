using StaffClockProject.Execution.Model;
using System.Collections.Generic;
using System.Linq;

namespace StaffClockProject.Execution.DAO {

    class UserDAO {

        public static void PersistUser(User usr) {
            var context = new StaffContext();
            context.Users.Add(usr);
            context.SaveChanges();
        }

        public static List<User> GetAllUsers() {
            return new StaffContext().Users.ToList();
        }

        public static void RemoveUser(User toRemove) {
            var context = new StaffContext();
            context.Users.Remove(toRemove);
            context.SaveChanges();
        }

        // Deletes the user with a specified "cadastro"
        public static void RemoveUser(string cadastro) {
            var context = new StaffContext();
            context.Users.Remove( new User(cadastro) );
            context.SaveChanges();
        }

    }

}
