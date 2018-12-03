
using System.ComponentModel.DataAnnotations;

namespace StaffClockProject.Execution.Model {

    class User {

        [Key]
        public string Cadastro { get; set; }

        public string Nome { get; set; }

        public User() {
            // For Entity Framework
        }

        public User(string cadastro) {
            this.Cadastro = cadastro;
        }

        public User(string cadastro, string nome) {
            this.Cadastro = cadastro;
            this.Nome = nome;
        }

    }

}
