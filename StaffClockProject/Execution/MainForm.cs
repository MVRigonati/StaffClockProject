using StaffClockProject.Execution;
using System;
using System.Windows.Forms;

namespace StaffClockProject {
    public partial class MainForm : Form {

        ConfigurationsMenu confMenu;

        public MainForm() {

            InitializeComponent();
            confMenu = new ConfigurationsMenu(this);
            confMenu.Hide();

        }

        private void button1_Click(object sender, EventArgs e) {

            var folderBrowser = new FolderBrowserDialog();

            DialogResult userResponse = DialogResult.No;
            if (folderBrowser.ShowDialog() == DialogResult.OK) {
                userResponse = MessageBox.Show(folderBrowser.SelectedPath,
                    "Confirme o caminho selecionado",
                    MessageBoxButtons.YesNo);
            }
            
            if (userResponse == DialogResult.Yes) {
                DownloadFile();
            }

        }

        private void DownloadFile() {
            MessageBox.Show("Realizando download...");
        }

        private void Menu_Configurations(object sender, EventArgs e) {
            
            confMenu.Show();
            this.Enabled = false;

        }

    }
}
