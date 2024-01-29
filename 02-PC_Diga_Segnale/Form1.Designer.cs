namespace PC_Diga_Segnale
{
    partial class frm_pcDigaSegnale
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.srl_routerGSM = new System.IO.Ports.SerialPort(this.components);
            this.tb_manutenzione = new System.Windows.Forms.TabPage();
            this.gb_diga = new System.Windows.Forms.GroupBox();
            this.btn_inserisciDatiDiga = new System.Windows.Forms.Button();
            this.cb_prefisso = new System.Windows.Forms.ComboBox();
            this.txt_numeroServer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_codiceDiga = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_gestioneRouter = new System.Windows.Forms.GroupBox();
            this.cb_serial_ports = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_configuraRouter = new System.Windows.Forms.Button();
            this.tb_sinottico = new System.Windows.Forms.TabPage();
            this.gb_simulazioneSensore = new System.Windows.Forms.GroupBox();
            this.btn_Preallerta = new System.Windows.Forms.Button();
            this.btn_allerta = new System.Windows.Forms.Button();
            this.gb_statoDiga = new System.Windows.Forms.GroupBox();
            this.lbl_statoDiga = new System.Windows.Forms.Label();
            this.tb_diga = new System.Windows.Forms.TabControl();
            this.tb_manutenzione.SuspendLayout();
            this.gb_diga.SuspendLayout();
            this.gb_gestioneRouter.SuspendLayout();
            this.tb_sinottico.SuspendLayout();
            this.gb_simulazioneSensore.SuspendLayout();
            this.gb_statoDiga.SuspendLayout();
            this.tb_diga.SuspendLayout();
            this.SuspendLayout();
            // 
            // srl_routerGSM
            // 
            this.srl_routerGSM.BaudRate = 115200;
            this.srl_routerGSM.DtrEnable = true;
            // 
            // tb_manutenzione
            // 
            this.tb_manutenzione.Controls.Add(this.gb_diga);
            this.tb_manutenzione.Controls.Add(this.gb_gestioneRouter);
            this.tb_manutenzione.Location = new System.Drawing.Point(4, 25);
            this.tb_manutenzione.Name = "tb_manutenzione";
            this.tb_manutenzione.Padding = new System.Windows.Forms.Padding(3);
            this.tb_manutenzione.Size = new System.Drawing.Size(434, 366);
            this.tb_manutenzione.TabIndex = 1;
            this.tb_manutenzione.Text = "Manutenzione";
            this.tb_manutenzione.UseVisualStyleBackColor = true;
            // 
            // gb_diga
            // 
            this.gb_diga.Controls.Add(this.btn_inserisciDatiDiga);
            this.gb_diga.Controls.Add(this.cb_prefisso);
            this.gb_diga.Controls.Add(this.txt_numeroServer);
            this.gb_diga.Controls.Add(this.label1);
            this.gb_diga.Controls.Add(this.txt_codiceDiga);
            this.gb_diga.Controls.Add(this.label2);
            this.gb_diga.Location = new System.Drawing.Point(16, 7);
            this.gb_diga.Margin = new System.Windows.Forms.Padding(4);
            this.gb_diga.Name = "gb_diga";
            this.gb_diga.Padding = new System.Windows.Forms.Padding(4);
            this.gb_diga.Size = new System.Drawing.Size(301, 181);
            this.gb_diga.TabIndex = 4;
            this.gb_diga.TabStop = false;
            this.gb_diga.Text = "Gestione diga";
            // 
            // btn_inserisciDatiDiga
            // 
            this.btn_inserisciDatiDiga.BackColor = System.Drawing.Color.Snow;
            this.btn_inserisciDatiDiga.Location = new System.Drawing.Point(27, 136);
            this.btn_inserisciDatiDiga.Name = "btn_inserisciDatiDiga";
            this.btn_inserisciDatiDiga.Size = new System.Drawing.Size(252, 34);
            this.btn_inserisciDatiDiga.TabIndex = 17;
            this.btn_inserisciDatiDiga.Text = "INSERISCI DATI";
            this.btn_inserisciDatiDiga.UseVisualStyleBackColor = false;
            this.btn_inserisciDatiDiga.Click += new System.EventHandler(this.btn_inserisciDatiDiga_Click);
            // 
            // cb_prefisso
            // 
            this.cb_prefisso.FormattingEnabled = true;
            this.cb_prefisso.Items.AddRange(new object[] {
            "+39",
            "+355",
            "+43",
            "+389",
            "+387",
            "+359",
            "+385",
            "+49",
            "+45",
            "+33",
            "+41",
            "+44",
            ""});
            this.cb_prefisso.Location = new System.Drawing.Point(27, 101);
            this.cb_prefisso.Name = "cb_prefisso";
            this.cb_prefisso.Size = new System.Drawing.Size(77, 24);
            this.cb_prefisso.TabIndex = 16;
            this.cb_prefisso.Text = "+39";
            // 
            // txt_numeroServer
            // 
            this.txt_numeroServer.Location = new System.Drawing.Point(110, 103);
            this.txt_numeroServer.Name = "txt_numeroServer";
            this.txt_numeroServer.Size = new System.Drawing.Size(169, 22);
            this.txt_numeroServer.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Numero server centrale:";
            // 
            // txt_codiceDiga
            // 
            this.txt_codiceDiga.Location = new System.Drawing.Point(27, 49);
            this.txt_codiceDiga.Name = "txt_codiceDiga";
            this.txt_codiceDiga.Size = new System.Drawing.Size(100, 22);
            this.txt_codiceDiga.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Codice diga:";
            // 
            // gb_gestioneRouter
            // 
            this.gb_gestioneRouter.Controls.Add(this.cb_serial_ports);
            this.gb_gestioneRouter.Controls.Add(this.label4);
            this.gb_gestioneRouter.Controls.Add(this.btn_configuraRouter);
            this.gb_gestioneRouter.Location = new System.Drawing.Point(16, 196);
            this.gb_gestioneRouter.Margin = new System.Windows.Forms.Padding(4);
            this.gb_gestioneRouter.Name = "gb_gestioneRouter";
            this.gb_gestioneRouter.Padding = new System.Windows.Forms.Padding(4);
            this.gb_gestioneRouter.Size = new System.Drawing.Size(301, 160);
            this.gb_gestioneRouter.TabIndex = 3;
            this.gb_gestioneRouter.TabStop = false;
            this.gb_gestioneRouter.Text = "Gestione router seriale";
            // 
            // cb_serial_ports
            // 
            this.cb_serial_ports.FormattingEnabled = true;
            this.cb_serial_ports.Location = new System.Drawing.Point(28, 55);
            this.cb_serial_ports.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_serial_ports.Name = "cb_serial_ports";
            this.cb_serial_ports.Size = new System.Drawing.Size(155, 24);
            this.cb_serial_ports.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Seleziona la porta:";
            // 
            // btn_configuraRouter
            // 
            this.btn_configuraRouter.BackColor = System.Drawing.Color.Snow;
            this.btn_configuraRouter.Location = new System.Drawing.Point(28, 101);
            this.btn_configuraRouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_configuraRouter.Name = "btn_configuraRouter";
            this.btn_configuraRouter.Size = new System.Drawing.Size(251, 42);
            this.btn_configuraRouter.TabIndex = 9;
            this.btn_configuraRouter.Text = "CONFIGURA";
            this.btn_configuraRouter.UseVisualStyleBackColor = false;
            this.btn_configuraRouter.Click += new System.EventHandler(this.btn_open_srl_Click);
            // 
            // tb_sinottico
            // 
            this.tb_sinottico.Controls.Add(this.gb_simulazioneSensore);
            this.tb_sinottico.Controls.Add(this.gb_statoDiga);
            this.tb_sinottico.Location = new System.Drawing.Point(4, 25);
            this.tb_sinottico.Name = "tb_sinottico";
            this.tb_sinottico.Padding = new System.Windows.Forms.Padding(3);
            this.tb_sinottico.Size = new System.Drawing.Size(434, 366);
            this.tb_sinottico.TabIndex = 0;
            this.tb_sinottico.Text = "Sinottico";
            this.tb_sinottico.UseVisualStyleBackColor = true;
            // 
            // gb_simulazioneSensore
            // 
            this.gb_simulazioneSensore.Controls.Add(this.btn_Preallerta);
            this.gb_simulazioneSensore.Controls.Add(this.btn_allerta);
            this.gb_simulazioneSensore.Enabled = false;
            this.gb_simulazioneSensore.Location = new System.Drawing.Point(18, 21);
            this.gb_simulazioneSensore.Margin = new System.Windows.Forms.Padding(4);
            this.gb_simulazioneSensore.Name = "gb_simulazioneSensore";
            this.gb_simulazioneSensore.Padding = new System.Windows.Forms.Padding(4);
            this.gb_simulazioneSensore.Size = new System.Drawing.Size(404, 129);
            this.gb_simulazioneSensore.TabIndex = 2;
            this.gb_simulazioneSensore.TabStop = false;
            this.gb_simulazioneSensore.Text = "Simulazione sensore";
            // 
            // btn_Preallerta
            // 
            this.btn_Preallerta.BackColor = System.Drawing.Color.DarkOrange;
            this.btn_Preallerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_Preallerta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Preallerta.Location = new System.Drawing.Point(29, 38);
            this.btn_Preallerta.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Preallerta.Name = "btn_Preallerta";
            this.btn_Preallerta.Size = new System.Drawing.Size(152, 59);
            this.btn_Preallerta.TabIndex = 0;
            this.btn_Preallerta.Text = "PREALLERTA";
            this.btn_Preallerta.UseVisualStyleBackColor = false;
            this.btn_Preallerta.Click += new System.EventHandler(this.btn_Preallerta_Click);
            // 
            // btn_allerta
            // 
            this.btn_allerta.BackColor = System.Drawing.Color.Red;
            this.btn_allerta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_allerta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_allerta.Location = new System.Drawing.Point(225, 38);
            this.btn_allerta.Margin = new System.Windows.Forms.Padding(4);
            this.btn_allerta.Name = "btn_allerta";
            this.btn_allerta.Size = new System.Drawing.Size(152, 59);
            this.btn_allerta.TabIndex = 1;
            this.btn_allerta.Text = "ALLERTA";
            this.btn_allerta.UseVisualStyleBackColor = false;
            this.btn_allerta.Click += new System.EventHandler(this.btn_allerta_Click);
            // 
            // gb_statoDiga
            // 
            this.gb_statoDiga.Controls.Add(this.lbl_statoDiga);
            this.gb_statoDiga.Location = new System.Drawing.Point(18, 158);
            this.gb_statoDiga.Margin = new System.Windows.Forms.Padding(4);
            this.gb_statoDiga.Name = "gb_statoDiga";
            this.gb_statoDiga.Padding = new System.Windows.Forms.Padding(4);
            this.gb_statoDiga.Size = new System.Drawing.Size(404, 110);
            this.gb_statoDiga.TabIndex = 5;
            this.gb_statoDiga.TabStop = false;
            this.gb_statoDiga.Text = "Stato diga";
            // 
            // lbl_statoDiga
            // 
            this.lbl_statoDiga.AutoSize = true;
            this.lbl_statoDiga.BackColor = System.Drawing.Color.LimeGreen;
            this.lbl_statoDiga.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.lbl_statoDiga.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_statoDiga.Location = new System.Drawing.Point(36, 36);
            this.lbl_statoDiga.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_statoDiga.Name = "lbl_statoDiga";
            this.lbl_statoDiga.Size = new System.Drawing.Size(326, 52);
            this.lbl_statoDiga.TabIndex = 6;
            this.lbl_statoDiga.Text = "Nessuna allerta";
            // 
            // tb_diga
            // 
            this.tb_diga.Controls.Add(this.tb_sinottico);
            this.tb_diga.Controls.Add(this.tb_manutenzione);
            this.tb_diga.Location = new System.Drawing.Point(12, 12);
            this.tb_diga.Name = "tb_diga";
            this.tb_diga.SelectedIndex = 0;
            this.tb_diga.Size = new System.Drawing.Size(442, 395);
            this.tb_diga.TabIndex = 6;
            // 
            // frm_pcDigaSegnale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 412);
            this.Controls.Add(this.tb_diga);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_pcDigaSegnale";
            this.Text = "PC diga segnale";
            this.Load += new System.EventHandler(this.frm_pcDigaSegnale_Load);
            this.tb_manutenzione.ResumeLayout(false);
            this.gb_diga.ResumeLayout(false);
            this.gb_diga.PerformLayout();
            this.gb_gestioneRouter.ResumeLayout(false);
            this.gb_gestioneRouter.PerformLayout();
            this.tb_sinottico.ResumeLayout(false);
            this.gb_simulazioneSensore.ResumeLayout(false);
            this.gb_statoDiga.ResumeLayout(false);
            this.gb_statoDiga.PerformLayout();
            this.tb_diga.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.IO.Ports.SerialPort srl_routerGSM;
        private System.Windows.Forms.TabPage tb_manutenzione;
        private System.Windows.Forms.GroupBox gb_diga;
        private System.Windows.Forms.ComboBox cb_prefisso;
        private System.Windows.Forms.TextBox txt_numeroServer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_codiceDiga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_gestioneRouter;
        private System.Windows.Forms.ComboBox cb_serial_ports;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_configuraRouter;
        private System.Windows.Forms.TabPage tb_sinottico;
        private System.Windows.Forms.GroupBox gb_simulazioneSensore;
        private System.Windows.Forms.Button btn_Preallerta;
        private System.Windows.Forms.Button btn_allerta;
        private System.Windows.Forms.TabControl tb_diga;
        private System.Windows.Forms.Button btn_inserisciDatiDiga;
        private System.Windows.Forms.GroupBox gb_statoDiga;
        private System.Windows.Forms.Label lbl_statoDiga;
    }
}

