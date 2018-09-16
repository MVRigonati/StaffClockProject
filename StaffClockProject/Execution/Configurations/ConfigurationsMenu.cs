using System;
using System.Windows.Forms;

namespace StaffClockProject.Execution {

    public partial class ConfigurationsMenu : Form {

        Form mainForm;

        public ConfigurationsMenu(Form mainForm) {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void FecharTodos() {
            pontoEletronicoPanel.Visible = false;
            excelPanel.Visible = false;
        }

        private void LeftMenuSaida(object sender, System.EventArgs e) {
            FecharTodos();
            excelPanel.Visible = true;
        }

        private void LeftMenuPontoEletronico(object sender, EventArgs e) {
            FecharTodos();
            pontoEletronicoPanel.Visible = true;
        }

        private void DefaulExit() {
            this.mainForm.Enabled = true;
            this.Hide();
        }

        private void LeftMenuVoltar(object sender, System.EventArgs e) {
            DefaulExit();
        }

        private void ClosingForm(object sender, FormClosingEventArgs e) {
            DefaulExit();
            e.Cancel = true; // Dispose Prevent
        }
    }

}
