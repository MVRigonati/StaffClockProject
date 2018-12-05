namespace StaffClockProject.Execution {
    partial class ConfigurationsMenu {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.textoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pontoEletronicoPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.UrlTextBox = new System.Windows.Forms.TextBox();
            this.DownloadPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listaCadastradosPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NomeTextBox = new System.Windows.Forms.TextBox();
            this.CadastroTextBox = new System.Windows.Forms.TextBox();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.UsersList = new System.Windows.Forms.ListView();
            this.Cad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label6 = new System.Windows.Forms.Label();
            this.WaitMinutesInput = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.DatabaseIPTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.pontoEletronicoPanel.SuspendLayout();
            this.listaCadastradosPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaitMinutesInput)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textoToolStripMenuItem,
            this.toolStripMenuItem2,
            this.voltarToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(9, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(115, 93);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // textoToolStripMenuItem
            // 
            this.textoToolStripMenuItem.Name = "textoToolStripMenuItem";
            this.textoToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 4, 10);
            this.textoToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.textoToolStripMenuItem.Text = "Ponto Eletrônico";
            this.textoToolStripMenuItem.Click += new System.EventHandler(this.LeftMenuPontoEletronico);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Padding = new System.Windows.Forms.Padding(4, 0, 4, 10);
            this.toolStripMenuItem2.Size = new System.Drawing.Size(108, 29);
            this.toolStripMenuItem2.Text = "Lista de Cadastro";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.LeftMenuListaCadastro);
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 4, 10);
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(108, 29);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.LeftMenuVoltar);
            // 
            // pontoEletronicoPanel
            // 
            this.pontoEletronicoPanel.AccessibleName = "";
            this.pontoEletronicoPanel.Controls.Add(this.label7);
            this.pontoEletronicoPanel.Controls.Add(this.DatabaseIPTextBox);
            this.pontoEletronicoPanel.Controls.Add(this.WaitMinutesInput);
            this.pontoEletronicoPanel.Controls.Add(this.label6);
            this.pontoEletronicoPanel.Controls.Add(this.button2);
            this.pontoEletronicoPanel.Controls.Add(this.label4);
            this.pontoEletronicoPanel.Controls.Add(this.label5);
            this.pontoEletronicoPanel.Controls.Add(this.label10);
            this.pontoEletronicoPanel.Controls.Add(this.PasswordTextBox);
            this.pontoEletronicoPanel.Controls.Add(this.UserTextBox);
            this.pontoEletronicoPanel.Controls.Add(this.UrlTextBox);
            this.pontoEletronicoPanel.Controls.Add(this.DownloadPath);
            this.pontoEletronicoPanel.Controls.Add(this.label1);
            this.pontoEletronicoPanel.Location = new System.Drawing.Point(125, 9);
            this.pontoEletronicoPanel.Name = "pontoEletronicoPanel";
            this.pontoEletronicoPanel.Size = new System.Drawing.Size(404, 271);
            this.pontoEletronicoPanel.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 228);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "Salvar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Senha de Login:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Usuário de Login:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(19, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(160, 17);
            this.label10.TabIndex = 12;
            this.label10.Text = "URL do Equipamento:";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(19, 189);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '●';
            this.PasswordTextBox.Size = new System.Drawing.Size(179, 20);
            this.PasswordTextBox.TabIndex = 11;
            // 
            // UserTextBox
            // 
            this.UserTextBox.Location = new System.Drawing.Point(19, 136);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(179, 20);
            this.UserTextBox.TabIndex = 10;
            // 
            // UrlTextBox
            // 
            this.UrlTextBox.Location = new System.Drawing.Point(19, 31);
            this.UrlTextBox.Name = "UrlTextBox";
            this.UrlTextBox.Size = new System.Drawing.Size(354, 20);
            this.UrlTextBox.TabIndex = 9;
            // 
            // DownloadPath
            // 
            this.DownloadPath.Location = new System.Drawing.Point(19, 82);
            this.DownloadPath.Name = "DownloadPath";
            this.DownloadPath.Size = new System.Drawing.Size(354, 20);
            this.DownloadPath.TabIndex = 8;
            this.DownloadPath.Click += new System.EventHandler(this.DownloadPath_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Caminho de Download:";
            // 
            // listaCadastradosPanel
            // 
            this.listaCadastradosPanel.AccessibleName = "";
            this.listaCadastradosPanel.BackColor = System.Drawing.SystemColors.Control;
            this.listaCadastradosPanel.Controls.Add(this.label3);
            this.listaCadastradosPanel.Controls.Add(this.label2);
            this.listaCadastradosPanel.Controls.Add(this.NomeTextBox);
            this.listaCadastradosPanel.Controls.Add(this.CadastroTextBox);
            this.listaCadastradosPanel.Controls.Add(this.RemoveButton);
            this.listaCadastradosPanel.Controls.Add(this.button1);
            this.listaCadastradosPanel.Controls.Add(this.UsersList);
            this.listaCadastradosPanel.Location = new System.Drawing.Point(125, 9);
            this.listaCadastradosPanel.Name = "listaCadastradosPanel";
            this.listaCadastradosPanel.Size = new System.Drawing.Size(404, 271);
            this.listaCadastradosPanel.TabIndex = 7;
            this.listaCadastradosPanel.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Cadastro:";
            // 
            // NomeTextBox
            // 
            this.NomeTextBox.Location = new System.Drawing.Point(94, 39);
            this.NomeTextBox.Name = "NomeTextBox";
            this.NomeTextBox.Size = new System.Drawing.Size(138, 20);
            this.NomeTextBox.TabIndex = 5;
            // 
            // CadastroTextBox
            // 
            this.CadastroTextBox.Location = new System.Drawing.Point(94, 13);
            this.CadastroTextBox.Name = "CadastroTextBox";
            this.CadastroTextBox.Size = new System.Drawing.Size(138, 20);
            this.CadastroTextBox.TabIndex = 4;
            // 
            // RemoveButton
            // 
            this.RemoveButton.Location = new System.Drawing.Point(314, 36);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(75, 23);
            this.RemoveButton.TabIndex = 3;
            this.RemoveButton.Text = "Remover";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(238, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddUserButton_Click);
            // 
            // UsersList
            // 
            this.UsersList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cad,
            this.Nome});
            this.UsersList.Location = new System.Drawing.Point(19, 74);
            this.UsersList.Name = "UsersList";
            this.UsersList.Size = new System.Drawing.Size(370, 177);
            this.UsersList.TabIndex = 0;
            this.UsersList.UseCompatibleStateImageBehavior = false;
            this.UsersList.View = System.Windows.Forms.View.Details;
            // 
            // Cad
            // 
            this.Cad.Text = "Cadastro";
            this.Cad.Width = 104;
            // 
            // Nome
            // 
            this.Nome.Text = "Nome";
            this.Nome.Width = 242;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(204, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Minutos de Espera:";
            // 
            // WaitMinutesInput
            // 
            this.WaitMinutesInput.Location = new System.Drawing.Point(207, 137);
            this.WaitMinutesInput.Name = "WaitMinutesInput";
            this.WaitMinutesInput.Size = new System.Drawing.Size(120, 20);
            this.WaitMinutesInput.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(204, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(176, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "IP do Banco de Dados:";
            // 
            // DatabaseIPTextBox
            // 
            this.DatabaseIPTextBox.Location = new System.Drawing.Point(204, 189);
            this.DatabaseIPTextBox.Name = "DatabaseIPTextBox";
            this.DatabaseIPTextBox.Size = new System.Drawing.Size(169, 20);
            this.DatabaseIPTextBox.TabIndex = 18;
            // 
            // ConfigurationsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 292);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pontoEletronicoPanel);
            this.Controls.Add(this.listaCadastradosPanel);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ConfigurationsMenu";
            this.Text = "Configurações";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingForm);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pontoEletronicoPanel.ResumeLayout(false);
            this.pontoEletronicoPanel.PerformLayout();
            this.listaCadastradosPanel.ResumeLayout(false);
            this.listaCadastradosPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WaitMinutesInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem textoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Panel pontoEletronicoPanel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Panel listaCadastradosPanel;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView UsersList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DownloadPath;
        private System.Windows.Forms.ColumnHeader Cad;
        private System.Windows.Forms.ColumnHeader Nome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NomeTextBox;
        private System.Windows.Forms.TextBox CadastroTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.TextBox UrlTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown WaitMinutesInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox DatabaseIPTextBox;
    }
}