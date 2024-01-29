namespace PC_Centrale
{
    partial class frm_pcCentrale
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
            this.gb_gestioneRouter = new System.Windows.Forms.GroupBox();
            this.btn_closeSrl = new System.Windows.Forms.Button();
            this.lbl_stato_porta = new System.Windows.Forms.Label();
            this.cb_serial_ports = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_open_srl = new System.Windows.Forms.Button();
            this.tb_diga = new System.Windows.Forms.TabControl();
            this.tb_sinottico = new System.Windows.Forms.TabPage();
            this.gb_sinottico = new System.Windows.Forms.GroupBox();
            this.lv_sinottico = new System.Windows.Forms.ListView();
            this.Codice_diga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statoDiga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_manutenzione = new System.Windows.Forms.TabPage();
            this.tmr_leggiMessaggi = new System.Windows.Forms.Timer(this.components);
            this.btn_leggi = new System.Windows.Forms.Button();
            this.gb_gestioneRouter.SuspendLayout();
            this.tb_diga.SuspendLayout();
            this.tb_sinottico.SuspendLayout();
            this.gb_sinottico.SuspendLayout();
            this.tb_manutenzione.SuspendLayout();
            this.SuspendLayout();
            // 
            // srl_routerGSM
            // 
            this.srl_routerGSM.BaudRate = 115200;
            this.srl_routerGSM.DtrEnable = true;
            this.srl_routerGSM.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.srl_routerGSM_DataReceived);
            // 
            // gb_gestioneRouter
            // 
            this.gb_gestioneRouter.Controls.Add(this.btn_closeSrl);
            this.gb_gestioneRouter.Controls.Add(this.lbl_stato_porta);
            this.gb_gestioneRouter.Controls.Add(this.cb_serial_ports);
            this.gb_gestioneRouter.Controls.Add(this.label4);
            this.gb_gestioneRouter.Controls.Add(this.btn_open_srl);
            this.gb_gestioneRouter.Location = new System.Drawing.Point(19, 17);
            this.gb_gestioneRouter.Margin = new System.Windows.Forms.Padding(4);
            this.gb_gestioneRouter.Name = "gb_gestioneRouter";
            this.gb_gestioneRouter.Padding = new System.Windows.Forms.Padding(4);
            this.gb_gestioneRouter.Size = new System.Drawing.Size(301, 168);
            this.gb_gestioneRouter.TabIndex = 4;
            this.gb_gestioneRouter.TabStop = false;
            this.gb_gestioneRouter.Text = "Gestione router";
            // 
            // btn_closeSrl
            // 
            this.btn_closeSrl.BackColor = System.Drawing.Color.Snow;
            this.btn_closeSrl.Location = new System.Drawing.Point(156, 101);
            this.btn_closeSrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_closeSrl.Name = "btn_closeSrl";
            this.btn_closeSrl.Size = new System.Drawing.Size(123, 42);
            this.btn_closeSrl.TabIndex = 12;
            this.btn_closeSrl.Text = "Chiudi la porta seriale";
            this.btn_closeSrl.UseVisualStyleBackColor = false;
            this.btn_closeSrl.Click += new System.EventHandler(this.btn_closeSrl_Click);
            // 
            // lbl_stato_porta
            // 
            this.lbl_stato_porta.AutoSize = true;
            this.lbl_stato_porta.Location = new System.Drawing.Point(188, 19);
            this.lbl_stato_porta.Name = "lbl_stato_porta";
            this.lbl_stato_porta.Size = new System.Drawing.Size(91, 17);
            this.lbl_stato_porta.TabIndex = 10;
            this.lbl_stato_porta.Text = "PORTA: OFF";
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
            // btn_open_srl
            // 
            this.btn_open_srl.BackColor = System.Drawing.Color.Snow;
            this.btn_open_srl.Location = new System.Drawing.Point(28, 101);
            this.btn_open_srl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_open_srl.Name = "btn_open_srl";
            this.btn_open_srl.Size = new System.Drawing.Size(123, 42);
            this.btn_open_srl.TabIndex = 9;
            this.btn_open_srl.Text = "Apri la porta seriale";
            this.btn_open_srl.UseVisualStyleBackColor = false;
            this.btn_open_srl.Click += new System.EventHandler(this.btn_open_srl_Click);
            // 
            // tb_diga
            // 
            this.tb_diga.Controls.Add(this.tb_sinottico);
            this.tb_diga.Controls.Add(this.tb_manutenzione);
            this.tb_diga.Location = new System.Drawing.Point(12, 12);
            this.tb_diga.Name = "tb_diga";
            this.tb_diga.SelectedIndex = 0;
            this.tb_diga.Size = new System.Drawing.Size(357, 223);
            this.tb_diga.TabIndex = 7;
            // 
            // tb_sinottico
            // 
            this.tb_sinottico.Controls.Add(this.gb_sinottico);
            this.tb_sinottico.Location = new System.Drawing.Point(4, 25);
            this.tb_sinottico.Name = "tb_sinottico";
            this.tb_sinottico.Padding = new System.Windows.Forms.Padding(3);
            this.tb_sinottico.Size = new System.Drawing.Size(349, 194);
            this.tb_sinottico.TabIndex = 0;
            this.tb_sinottico.Text = "Sinottico";
            this.tb_sinottico.UseVisualStyleBackColor = true;
            // 
            // gb_sinottico
            // 
            this.gb_sinottico.Controls.Add(this.lv_sinottico);
            this.gb_sinottico.Location = new System.Drawing.Point(18, 15);
            this.gb_sinottico.Name = "gb_sinottico";
            this.gb_sinottico.Size = new System.Drawing.Size(314, 168);
            this.gb_sinottico.TabIndex = 10;
            this.gb_sinottico.TabStop = false;
            this.gb_sinottico.Text = "Sinottico";
            // 
            // lv_sinottico
            // 
            this.lv_sinottico.BackColor = System.Drawing.Color.Snow;
            this.lv_sinottico.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codice_diga,
            this.statoDiga});
            this.lv_sinottico.HideSelection = false;
            this.lv_sinottico.Location = new System.Drawing.Point(20, 21);
            this.lv_sinottico.Name = "lv_sinottico";
            this.lv_sinottico.Size = new System.Drawing.Size(268, 139);
            this.lv_sinottico.TabIndex = 9;
            this.lv_sinottico.UseCompatibleStateImageBehavior = false;
            this.lv_sinottico.View = System.Windows.Forms.View.Details;
            // 
            // Codice_diga
            // 
            this.Codice_diga.Text = "Codice diga";
            this.Codice_diga.Width = 141;
            // 
            // statoDiga
            // 
            this.statoDiga.Text = "Stato diga";
            this.statoDiga.Width = 122;
            // 
            // tb_manutenzione
            // 
            this.tb_manutenzione.Controls.Add(this.gb_gestioneRouter);
            this.tb_manutenzione.Location = new System.Drawing.Point(4, 25);
            this.tb_manutenzione.Name = "tb_manutenzione";
            this.tb_manutenzione.Padding = new System.Windows.Forms.Padding(3);
            this.tb_manutenzione.Size = new System.Drawing.Size(349, 194);
            this.tb_manutenzione.TabIndex = 1;
            this.tb_manutenzione.Text = "Manutenzione";
            this.tb_manutenzione.UseVisualStyleBackColor = true;
            // 
            // tmr_leggiMessaggi
            // 
            this.tmr_leggiMessaggi.Interval = 60000;
            this.tmr_leggiMessaggi.Tick += new System.EventHandler(this.tmr_leggiMessaggi_Tick);
            // 
            // btn_leggi
            // 
            this.btn_leggi.Location = new System.Drawing.Point(139, 242);
            this.btn_leggi.Name = "btn_leggi";
            this.btn_leggi.Size = new System.Drawing.Size(100, 33);
            this.btn_leggi.TabIndex = 8;
            this.btn_leggi.Text = "Leggi";
            this.btn_leggi.UseVisualStyleBackColor = true;
            this.btn_leggi.Click += new System.EventHandler(this.btn_leggi_Click);
            // 
            // frm_pcCentrale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 300);
            this.Controls.Add(this.btn_leggi);
            this.Controls.Add(this.tb_diga);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_pcCentrale";
            this.Text = "PC centrale";
            this.Load += new System.EventHandler(this.frm_pcCentrale_Load);
            this.gb_gestioneRouter.ResumeLayout(false);
            this.gb_gestioneRouter.PerformLayout();
            this.tb_diga.ResumeLayout(false);
            this.tb_sinottico.ResumeLayout(false);
            this.gb_sinottico.ResumeLayout(false);
            this.tb_manutenzione.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.Ports.SerialPort srl_routerGSM;
        private System.Windows.Forms.GroupBox gb_gestioneRouter;
        private System.Windows.Forms.Button btn_closeSrl;
        private System.Windows.Forms.Label lbl_stato_porta;
        private System.Windows.Forms.ComboBox cb_serial_ports;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_open_srl;
        private System.Windows.Forms.TabControl tb_diga;
        private System.Windows.Forms.TabPage tb_sinottico;
        private System.Windows.Forms.TabPage tb_manutenzione;
        private System.Windows.Forms.GroupBox gb_sinottico;
        private System.Windows.Forms.ListView lv_sinottico;
        private System.Windows.Forms.ColumnHeader Codice_diga;
        private System.Windows.Forms.ColumnHeader statoDiga;
        private System.Windows.Forms.Timer tmr_leggiMessaggi;
        private System.Windows.Forms.Button btn_leggi;
    }
}

