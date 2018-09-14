using System;
using System.Windows.Forms;

namespace StaffClockProject.Execution {

    public partial class ConfigurationsMenu : Form {

        Form mainForm;

        public ConfigurationsMenu(Form mainForm) {

            this.mainForm = mainForm;
            InitializeComponent();

        }

        private void LeftMenuVoltar(object sender, System.EventArgs e) {

            this.mainForm.Enabled = true;
            this.Hide();

        }

        private void FecharTodos() {
            pontoEletronicoPanel.Visible = false;
            saidaPanel.Visible = false;
        }

        private void LeftMenuSaida(object sender, System.EventArgs e) {

            FecharTodos();
            saidaPanel.Visible = true;

        }

        private void LeftMenuPontoEletronico(object sender, EventArgs e) {

            FecharTodos();
            pontoEletronicoPanel.Visible = true;

        }

    }
    
}
