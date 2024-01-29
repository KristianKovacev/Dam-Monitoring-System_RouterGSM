namespace PC_Diga_KeepAlive
{
    partial class frm_pcDigaKeepAlive
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
            this.tmr_keepAlive = new System.Windows.Forms.Timer(this.components);
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.gb_keepAlive = new System.Windows.Forms.GroupBox();
            this.srl_routerGSM = new System.IO.Ports.SerialPort(this.components);
            this.gb_Diagnostica = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_millisecondiTimer = new System.Windows.Forms.TextBox();
            this.btn_aggiornaTimer = new System.Windows.Forms.Button();
            this.gb_gestioneRouter = new System.Windows.Forms.GroupBox();
            this.cb_serial_ports = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_configura = new System.Windows.Forms.Button();
            this.tb_diga = new System.Windows.Forms.TabControl();
            this.tb_keepAlive = new System.Windows.Forms.TabPage();
            this.tb_manutenzione = new System.Windows.Forms.TabPage();
            this.gb_diga = new System.Windows.Forms.GroupBox();
            this.btn_inserisciDatiDiga = new System.Windows.Forms.Button();
            this.cb_prefisso = new System.Windows.Forms.ComboBox();
            this.txt_numeroServer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_codiceDiga = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gb_keepAlive.SuspendLayout();
            this.gb_Diagnostica.SuspendLayout();
            this.gb_gestioneRouter.SuspendLayout();
            this.tb_diga.SuspendLayout();
            this.tb_keepAlive.SuspendLayout();
            this.tb_manutenzione.SuspendLayout();
            this.gb_diga.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmr_keepAlive
            // 
            this.tmr_keepAlive.Interval = 60000;
            this.tmr_keepAlive.Tick += new System.EventHandler(this.tmr_keepAlive_Tick);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.Snow;
            this.btn_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_start.Location = new System.Drawing.Point(25, 37);
            this.btn_start.Margin = new System.Windows.Forms.Padding(4);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(156, 58);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "START";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.BackColor = System.Drawing.Color.Snow;
            this.btn_stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_stop.Location = new System.Drawing.Point(219, 37);
            this.btn_stop.Margin = new System.Windows.Forms.Padding(4);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(156, 58);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.Text = "STOP";
            this.btn_stop.UseVisualStyleBackColor = false;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // gb_keepAlive
            // 
            this.gb_keepAlive.Controls.Add(this.btn_start);
            this.gb_keepAlive.Controls.Add(this.btn_stop);
            this.gb_keepAlive.Location = new System.Drawing.Point(21, 17);
            this.gb_keepAlive.Margin = new System.Windows.Forms.Padding(4);
            this.gb_keepAlive.Name = "gb_keepAlive";
            this.gb_keepAlive.Padding = new System.Windows.Forms.Padding(4);
            this.gb_keepAlive.Size = new System.Drawing.Size(411, 121);
            this.gb_keepAlive.TabIndex = 2;
            this.gb_keepAlive.TabStop = false;
            this.gb_keepAlive.Text = "Keep alive";
            // 
            // srl_routerGSM
            // 
            this.srl_routerGSM.BaudRate = 115200;
            this.srl_routerGSM.DtrEnable = true;
            // 
            // gb_Diagnostica
            // 
            this.gb_Diagnostica.Controls.Add(this.label2);
            this.gb_Diagnostica.Controls.Add(this.label1);
            this.gb_Diagnostica.Controls.Add(this.txt_millisecondiTimer);
            this.gb_Diagnostica.Controls.Add(this.btn_aggiornaTimer);
            this.gb_Diagnostica.Location = new System.Drawing.Point(16, 206);
            this.gb_Diagnostica.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Diagnostica.Name = "gb_Diagnostica";
            this.gb_Diagnostica.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Diagnostica.Size = new System.Drawing.Size(610, 134);
            this.gb_Diagnostica.TabIndex = 3;
            this.gb_Diagnostica.TabStop = false;
            this.gb_Diagnostica.Text = "Diagnostica";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "ms";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inserisci ogni quanto mandare il keep alive";
            // 
            // txt_millisecondiTimer
            // 
            this.txt_millisecondiTimer.Location = new System.Drawing.Point(29, 57);
            this.txt_millisecondiTimer.Margin = new System.Windows.Forms.Padding(4);
            this.txt_millisecondiTimer.Name = "txt_millisecondiTimer";
            this.txt_millisecondiTimer.Size = new System.Drawing.Size(184, 22);
            this.txt_millisecondiTimer.TabIndex = 3;
            // 
            // btn_aggiornaTimer
            // 
            this.btn_aggiornaTimer.BackColor = System.Drawing.Color.Snow;
            this.btn_aggiornaTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_aggiornaTimer.Location = new System.Drawing.Point(316, 40);
            this.btn_aggiornaTimer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_aggiornaTimer.Name = "btn_aggiornaTimer";
            this.btn_aggiornaTimer.Size = new System.Drawing.Size(272, 75);
            this.btn_aggiornaTimer.TabIndex = 0;
            this.btn_aggiornaTimer.Text = "AGGIORNA INTERVALLO";
            this.btn_aggiornaTimer.UseVisualStyleBackColor = false;
            this.btn_aggiornaTimer.Click += new System.EventHandler(this.btn_startDiagnostica_Click);
            // 
            // gb_gestioneRouter
            // 
            this.gb_gestioneRouter.Controls.Add(this.cb_serial_ports);
            this.gb_gestioneRouter.Controls.Add(this.label4);
            this.gb_gestioneRouter.Controls.Add(this.btn_configura);
            this.gb_gestioneRouter.Location = new System.Drawing.Point(325, 13);
            this.gb_gestioneRouter.Margin = new System.Windows.Forms.Padding(4);
            this.gb_gestioneRouter.Name = "gb_gestioneRouter";
            this.gb_gestioneRouter.Padding = new System.Windows.Forms.Padding(4);
            this.gb_gestioneRouter.Size = new System.Drawing.Size(301, 175);
            this.gb_gestioneRouter.TabIndex = 4;
            this.gb_gestioneRouter.TabStop = false;
            this.gb_gestioneRouter.Text = "Gestione router";
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
            // btn_configura
            // 
            this.btn_configura.BackColor = System.Drawing.Color.Snow;
            this.btn_configura.Location = new System.Drawing.Point(28, 101);
            this.btn_configura.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_configura.Name = "btn_configura";
            this.btn_configura.Size = new System.Drawing.Size(251, 42);
            this.btn_configura.TabIndex = 9;
            this.btn_configura.Text = "CONFIGURA";
            this.btn_configura.UseVisualStyleBackColor = false;
            this.btn_configura.Click += new System.EventHandler(this.btn_open_srl_Click);
            // 
            // tb_diga
            // 
            this.tb_diga.Controls.Add(this.tb_keepAlive);
            this.tb_diga.Controls.Add(this.tb_manutenzione);
            this.tb_diga.Location = new System.Drawing.Point(23, 12);
            this.tb_diga.Name = "tb_diga";
            this.tb_diga.SelectedIndex = 0;
            this.tb_diga.Size = new System.Drawing.Size(655, 382);
            this.tb_diga.TabIndex = 7;
            // 
            // tb_keepAlive
            // 
            this.tb_keepAlive.Controls.Add(this.gb_keepAlive);
            this.tb_keepAlive.Location = new System.Drawing.Point(4, 25);
            this.tb_keepAlive.Name = "tb_keepAlive";
            this.tb_keepAlive.Padding = new System.Windows.Forms.Padding(3);
            this.tb_keepAlive.Size = new System.Drawing.Size(647, 353);
            this.tb_keepAlive.TabIndex = 0;
            this.tb_keepAlive.Text = "Keep alive";
            this.tb_keepAlive.UseVisualStyleBackColor = true;
            // 
            // tb_manutenzione
            // 
            this.tb_manutenzione.Controls.Add(this.gb_diga);
            this.tb_manutenzione.Controls.Add(this.gb_Diagnostica);
            this.tb_manutenzione.Controls.Add(this.gb_gestioneRouter);
            this.tb_manutenzione.Location = new System.Drawing.Point(4, 25);
            this.tb_manutenzione.Name = "tb_manutenzione";
            this.tb_manutenzione.Padding = new System.Windows.Forms.Padding(3);
            this.tb_manutenzione.Size = new System.Drawing.Size(647, 353);
            this.tb_manutenzione.TabIndex = 1;
            this.tb_manutenzione.Text = "Manutenzione";
            this.tb_manutenzione.UseVisualStyleBackColor = true;
            // 
            // gb_diga
            // 
            this.gb_diga.Controls.Add(this.btn_inserisciDatiDiga);
            this.gb_diga.Controls.Add(this.cb_prefisso);
            this.gb_diga.Controls.Add(this.txt_numeroServer);
            this.gb_diga.Controls.Add(this.label3);
            this.gb_diga.Controls.Add(this.txt_codiceDiga);
            this.gb_diga.Controls.Add(this.label5);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Numero server centrale:";
            // 
            // txt_codiceDiga
            // 
            this.txt_codiceDiga.Location = new System.Drawing.Point(27, 49);
            this.txt_codiceDiga.Name = "txt_codiceDiga";
            this.txt_codiceDiga.Size = new System.Drawing.Size(100, 22);
            this.txt_codiceDiga.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Codice diga:";
            // 
            // frm_pcDigaKeepAlive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 404);
            this.Controls.Add(this.tb_diga);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_pcDigaKeepAlive";
            this.Text = "PC diga keep alive";
            this.Load += new System.EventHandler(this.frm_pcDigaKeepAlive_Load);
            this.gb_keepAlive.ResumeLayout(false);
            this.gb_Diagnostica.ResumeLayout(false);
            this.gb_Diagnostica.PerformLayout();
            this.gb_gestioneRouter.ResumeLayout(false);
            this.gb_gestioneRouter.PerformLayout();
            this.tb_diga.ResumeLayout(false);
            this.tb_keepAlive.ResumeLayout(false);
            this.tb_manutenzione.ResumeLayout(false);
            this.gb_diga.ResumeLayout(false);
            this.gb_diga.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmr_keepAlive;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.GroupBox gb_keepAlive;
        private System.IO.Ports.SerialPort srl_routerGSM;
        private System.Windows.Forms.GroupBox gb_Diagnostica;
        private System.Windows.Forms.Button btn_aggiornaTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_millisecondiTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gb_gestioneRouter;
        private System.Windows.Forms.ComboBox cb_serial_ports;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_configura;
        private System.Windows.Forms.TabControl tb_diga;
        private System.Windows.Forms.TabPage tb_keepAlive;
        private System.Windows.Forms.TabPage tb_manutenzione;
        private System.Windows.Forms.GroupBox gb_diga;
        private System.Windows.Forms.Button btn_inserisciDatiDiga;
        private System.Windows.Forms.ComboBox cb_prefisso;
        private System.Windows.Forms.TextBox txt_numeroServer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_codiceDiga;
        private System.Windows.Forms.Label label5;
    }
}

