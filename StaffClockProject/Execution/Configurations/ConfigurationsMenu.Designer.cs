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
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.voltarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pontoEletronicoPanel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.excelPanel = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1.SuspendLayout();
            this.pontoEletronicoPanel.SuspendLayout();
            this.excelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItem,
            this.textoToolStripMenuItem,
            this.voltarToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(9, 9);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(113, 93);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 4, 10);
            this.textToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.textToolStripMenuItem.Text = "Excel";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.LeftMenuSaida);
            // 
            // textoToolStripMenuItem
            // 
            this.textoToolStripMenuItem.Name = "textoToolStripMenuItem";
            this.textoToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 4, 10);
            this.textoToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.textoToolStripMenuItem.Text = "Ponto Eletrônico";
            this.textoToolStripMenuItem.Click += new System.EventHandler(this.LeftMenuPontoEletronico);
            // 
            // voltarToolStripMenuItem
            // 
            this.voltarToolStripMenuItem.Name = "voltarToolStripMenuItem";
            this.voltarToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 4, 10);
            this.voltarToolStripMenuItem.Size = new System.Drawing.Size(106, 29);
            this.voltarToolStripMenuItem.Text = "Voltar";
            this.voltarToolStripMenuItem.Click += new System.EventHandler(this.LeftMenuVoltar);
            // 
            // pontoEletronicoPanel
            // 
            this.pontoEletronicoPanel.AccessibleName = "";
            this.pontoEletronicoPanel.Controls.Add(this.dateTimePicker2);
            this.pontoEletronicoPanel.Controls.Add(this.dateTimePicker1);
            this.pontoEletronicoPanel.Controls.Add(this.label5);
            this.pontoEletronicoPanel.Controls.Add(this.label4);
            this.pontoEletronicoPanel.Location = new System.Drawing.Point(125, 9);
            this.pontoEletronicoPanel.Name = "pontoEletronicoPanel";
            this.pontoEletronicoPanel.Size = new System.Drawing.Size(404, 271);
            this.pontoEletronicoPanel.TabIndex = 1;
            this.pontoEletronicoPanel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data Final de Avaliação:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(216, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Data Inicial de Avaliação:";
            // 
            // excelPanel
            // 
            this.excelPanel.AccessibleName = "";
            this.excelPanel.Controls.Add(this.label10);
            this.excelPanel.Location = new System.Drawing.Point(125, 9);
            this.excelPanel.Name = "excelPanel";
            this.excelPanel.Size = new System.Drawing.Size(404, 271);
            this.excelPanel.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(16, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(144, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Caminho de Saída:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(238, 16);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(238, 54);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(163, 20);
            this.dateTimePicker2.TabIndex = 6;
            // 
            // ConfigurationsMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 292);
            this.Controls.Add(this.excelPanel);
            this.Controls.Add(this.pontoEletronicoPanel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ConfigurationsMenu";
            this.Text = "Configurações";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClosingForm);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pontoEletronicoPanel.ResumeLayout(false);
            this.pontoEletronicoPanel.PerformLayout();
            this.excelPanel.ResumeLayout(false);
            this.excelPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem voltarToolStripMenuItem;
        private System.Windows.Forms.Panel pontoEletronicoPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel excelPanel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}