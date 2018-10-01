using StaffClockProject.Execution.Configurations;
using StaffClockProject.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StaffClockProject.Execution {

    public partial class ConfigurationsMenu : Form {

        Form mainForm;

        public static DateTime InitialDate { get; private set; }
        public static DateTime EndDate { get; private set; }
        public static string OutputPath { get; private set; }
        public static string UserListPath { get; private set; }
        public static Dictionary<string, string> Users { get; private set; }

        public ConfigurationsMenu(Form mainForm) {
            this.mainForm = mainForm;
            FillConfigurations();
            InitializeComponent();
        }

        private void FillConfigurations() {
            OutputPath = (string)Settings.Default["OutputPath"];
            UserListPath = (string)Settings.Default["UserListPath"];
            InitialDate = (DateTime) Settings.Default["InitialDate"];
            EndDate = (DateTime) Settings.Default["EndDate"];
            Users = UserListManager.LoadList(UserListPath);

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

        private void SaveStripMenu_Click(object sender, EventArgs e) {

            Settings.Default["OutputPath"] = OutputPath;
            Settings.Default["UserListPath"] = UserListPath;
            Settings.Default["InitialDate"] = InitialDate;
            Settings.Default["EndDate"] = EndDate;
            UserListManager.SaveList(Users, UserListPath);

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e) {

        }
    }

}
