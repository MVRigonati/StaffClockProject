using StaffClockProject.Execution.Configurations;
using StaffClockProject.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StaffClockProject.Execution {

    public partial class ConfigurationsMenu : Form {

        Form mainForm;

        public static string UserListPath { get; private set; }
        public static DateTime InitialDate { get; private set; }
        public static DateTime EndDate { get; private set; }
        public static Dictionary<string, string> Users { get; private set; }
        public static string OutputPath {

            get {
                return Settings.Default.OutputPath;
            }

        }

        public ConfigurationsMenu(Form mainForm) {

            this.mainForm = mainForm;
            FillConfigurations();

            InitializeComponent();
            FillComponentValues();

        }

        private void FillConfigurations() {

            ConfigurationsMenu.UserListPath = Settings.Default.UserListPath;
            Users = UserListManager.LoadList(UserListPath);

        }

        private void FillComponentValues() {
            InitialDatePicker.Value = Settings.Default.InitialDate;
            EndDatePicker.Value = Settings.Default.EndDate;
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

        private void DefaultExit() {
            this.mainForm.Enabled = true;
            this.Hide();
        }

        private void LeftMenuVoltar(object sender, System.EventArgs e) {
            DefaultExit();
        }

        private void ClosingForm(object sender, FormClosingEventArgs e) {
            DefaultExit();
            e.Cancel = true; // Dispose Prevent
        }

        private void SaveStripMenu_Click(object sender, EventArgs e) {

            UserListManager.SaveList(Users, UserListPath);
            Settings.Default.Save();
            MessageBox.Show("Configurações salvas com sucesso!");

        }

        private void OutputPathButton_Click(object sender, EventArgs e) {

            FolderBrowserDialog selectOutPath = new FolderBrowserDialog {
                SelectedPath = Settings.Default.OutputPath
            };

            if (selectOutPath.ShowDialog() == DialogResult.OK) {
                Settings.Default.OutputPath = selectOutPath.SelectedPath;
            }

        }

        private void InitialDatePickerChanged(object sender, EventArgs e) {
            Settings.Default.InitialDate = InitialDatePicker.Value;
        }

        private void EndDatePickerChanged(object sender, EventArgs e) {
            Settings.Default.EndDate = EndDatePicker.Value;
        }

    }

}
