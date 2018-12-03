using StaffClockProject.Execution;
using StaffClockProject.Execution.DAO;
using StaffClockProject.Execution.ExcelTimeSheet.DownloadFile;
using StaffClockProject.Execution.ExcelTimeSheet.Parse;
using StaffClockProject.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace StaffClockProject {
    public partial class MainForm : Form {

        public ConfigurationsMenu ConfMenu { get; private set; }

        public MainForm() {

            InitializeComponent();
            ConfMenu = new ConfigurationsMenu(this);

            ConfMenu.Hide();
            FillInformations();

        }

        private void FillInformations() {

            InitialDatePicker.Value = Settings.Default.InitialDate;
            EndDatePicker.Value = Settings.Default.EndDate;

        }

        private void Menu_Configurations(object sender, EventArgs e) {
            ConfMenu.Show();
            this.Enabled = false;
        }

        private string ReadLocalFile(string filePath) {

            string[] files = Directory.GetFiles(filePath);
            string[] lines = File.ReadAllLines(files[0]);
            File.Delete(files[0]);

            string result = "";
            foreach (string line in lines) {
                result += " " + line;
            }
            return result;

        }

        private void SaveToDatabaseButton_Click(object sender, EventArgs e) {

            try {
                DownloadManager.DownloadFileFrom(Settings.Default.Url, Settings.Default.User, Settings.Default.Password);
                string eventsTxt = ReadLocalFile(Settings.Default.PathToSave);
                var events = ParseManager.BuildEvents(eventsTxt);

                var eventConector = new EventDAO();
                events.ForEach( 
                    oneEvent => eventConector.PersistEvent(oneEvent)
                );

                MessageBox.Show("Operação concluida.");

            } catch (IOException) {
                MessageBox.Show(
                    "Não foi possível recuperar o arquivo, verifique a conexão com o dispositivo.",
                    "Erro ao Ler Arquivo");
            }

        }

        private void SaveValues_Click(object sender, EventArgs e) {

            Settings.Default.Save();
            MessageBox.Show("Configurações salvas com sucesso!", "Salvar");

        }

        private void InitialDate_ValueChanged(object sender, EventArgs e) {
            Settings.Default.InitialDate = InitialDatePicker.Value;
        }

        private void EndDate_ValueChanged(object sender, EventArgs e) {
            Settings.Default.EndDate = EndDatePicker.Value;
        }
    }
}
