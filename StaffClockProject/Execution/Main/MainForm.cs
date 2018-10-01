using StaffClockProject.Execution;
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
        }

        private void Menu_Configurations(object sender, EventArgs e) {
            ConfMenu.Show();
            this.Enabled = false;
        }

        private void OnlyLocalCheckBox_CheckedChanged(object sender, EventArgs e) {
            UseLocalFile.Enabled = !UseLocalFile.Enabled;
        }

        private void SelectLocalFileButton_Click(object sender, EventArgs e) {

            var folderBrowser = new OpenFileDialog();

            var userResponse = DialogResult.No;
            if (folderBrowser.ShowDialog() == DialogResult.OK) {
                userResponse = MessageBox.Show(folderBrowser.FileName,
                    "Confirme o nome do arquivo",
                    MessageBoxButtons.YesNo);
            }

            if (userResponse == DialogResult.Yes) {
                MakeTheMagic(folderBrowser);

            }

        }

        private void MakeTheMagic(OpenFileDialog folderBrowser) {
            
            try {
                string eventsFile = ReadLocalFile(folderBrowser.FileName);
                MessageBox.Show(eventsFile);
                // magic

            } catch (IOException) {
                MessageBox.Show(
                    "Não foi possível recuperar o arquivo, verifique o caminho selecionado.",
                    "Erro ao Ler Arquivo");
            }

        }

        private string ReadLocalFile(string filePath) {

            string result = "";
            foreach (string line in File.ReadAllLines(filePath)) {
                result += " " + line;
            }
            return result;
        }
    }
}
