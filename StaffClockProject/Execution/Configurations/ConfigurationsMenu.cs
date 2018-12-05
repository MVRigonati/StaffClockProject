using Microsoft.EntityFrameworkCore;
using StaffClockProject.Execution.DAO;
using StaffClockProject.Execution.Model;
using StaffClockProject.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace StaffClockProject.Execution {

    public partial class ConfigurationsMenu : Form {

        Form mainForm;
        
        public static string PathToSave {
            get {
                return Settings.Default.PathToSave;
            }
        }

        public static Dictionary<string, string> Users { get; private set; }

        public ConfigurationsMenu(Form mainForm) {

            this.mainForm = mainForm;
            InitializeComponent();
            FillComponentValues();

        }

        private void FillComponentValues() {

            UrlTextBox.Text = Settings.Default.Url;
            UserTextBox.Text = Settings.Default.User;
            PasswordTextBox.Text = Settings.Default.Password;
            DownloadPath.Text = Settings.Default.PathToSave;
            DatabaseIPTextBox.Text = Settings.Default.DatabaseIP;
            WaitMinutesInput.Value = Settings.Default.WaitMin;

            LoadUsersList();

        }

        private void LoadUsersList() {
            
            UsersList.Items.Clear();

            try {

                // Gets all registrered users from database
                foreach (User usr in UserDAO.GetAllUsers()) {

                    // Creates a list row
                    var userListItem = new ListViewItem(usr.Cadastro);
                    userListItem.SubItems.Add(usr.Nome);

                    // Adds the row to the list
                    UsersList.Items.Add(userListItem);

                }

            } catch (SqlException) {
                MessageBox.Show("Não foi possível realizar conexão com banco de dados.\n" +
                    "Verifique o IP especificado nas configurações e a disponibilidade do banco.");

            }

        }

        private void FecharTodos() {
            pontoEletronicoPanel.Visible = false;
            listaCadastradosPanel.Visible = false;
        }

        private void LeftMenuSaida(object sender, EventArgs e) {
            FecharTodos();
        }

        private void LeftMenuPontoEletronico(object sender, EventArgs e) {
            FecharTodos();
            pontoEletronicoPanel.Visible = true;
        }

        private void LeftMenuListaCadastro(object sender, EventArgs e) {
            FecharTodos();
            listaCadastradosPanel.Visible = true;
        }

        private void DefaultExit() {
            this.mainForm.Enabled = true;
            this.Hide();
        }

        private void LeftMenuVoltar(object sender, EventArgs e) {
            DefaultExit();
        }

        private void ClosingForm(object sender, FormClosingEventArgs e) {
            DefaultExit();
            e.Cancel = true; // Dispose Prevent
        }

        private void DownloadPath_Click(object sender, EventArgs e) {

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK) {

                DownloadPath.Text = dialog.SelectedPath;
                Settings.Default.PathToSave = DownloadPath.Text;

            }

        }

        private void RemoveButton_Click(object sender, EventArgs e) {

            SelectedListViewItemCollection selectedItensCollection = UsersList.SelectedItems;
            IEnumerator selectedItens = selectedItensCollection.GetEnumerator();

            while (selectedItens.MoveNext()) {

                ListViewItem usr = (ListViewItem) selectedItens.Current;
                DialogResult response = MessageBox.Show("Tem certeza de que deseja excluir?\n"
                    + usr.Text + " - " + usr.SubItems[1].Text, "Remoção",
                    MessageBoxButtons.YesNo);

                if (response == DialogResult.Yes) {
                    UserDAO.RemoveUser(usr.Text);
                }

            }

            LoadUsersList();

        }

        private void AddUserButton_Click(object sender, EventArgs e) {

            if (!CadastroTextBox.Text.Equals("") && !NomeTextBox.Text.Equals("")) {

                try {
                    UserDAO.PersistUser( new User(CadastroTextBox.Text, NomeTextBox.Text) );
                    MessageBox.Show("Usuário adiconado.");

                } catch (DbUpdateException) {
                    // When user tries to add an existing primary key
                    MessageBox.Show("Campo 'Cadastro' já foi adicionado e não pode ser duplicado.");
                }

            } else {
                MessageBox.Show("Campo 'Cadastro' e 'Nome' não estão preenchidos.");
            }

            LoadUsersList();

        }

        private void SaveButton_Click(object sender, EventArgs e) {

            Settings.Default.Url = UrlTextBox.Text;
            Settings.Default.User = UserTextBox.Text;
            Settings.Default.Password = PasswordTextBox.Text;
            Settings.Default.PathToSave = DownloadPath.Text;
            Settings.Default.DatabaseIP = DatabaseIPTextBox.Text;
            Settings.Default.WaitMin = (int)WaitMinutesInput.Value;

            Settings.Default.Save();
            MessageBox.Show("Valores salvos com sucesso!", "Salvar");

        }
    }

}
