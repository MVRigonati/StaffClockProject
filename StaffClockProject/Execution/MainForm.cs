using System;
using System.Windows.Forms;

namespace StaffClockProject {
    public partial class MainForm : Form {

        public MainForm() {
            InitializeComponent();
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
                downloadFile();
            }

        }

        private void downloadFile() {
            MessageBox.Show("Realizando download...");
        }

    }
}
