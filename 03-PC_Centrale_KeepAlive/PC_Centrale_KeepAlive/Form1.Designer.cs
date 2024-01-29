
namespace PC_Centrale_KeepAlive
{
    partial class frm_PcCentrale_KeepAlive
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
            this.gb_keepAlive = new System.Windows.Forms.GroupBox();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.tb_diga = new System.Windows.Forms.TabControl();
            this.tb_keepAlive = new System.Windows.Forms.TabPage();
            this.tb_manutenzione = new System.Windows.Forms.TabPage();
            this.gb_Diagnostica = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_minutiTimer = new System.Windows.Forms.TextBox();
            this.btn_aggiornaTimer = new System.Windows.Forms.Button();
            this.lv_sinottico = new System.Windows.Forms.ListView();
            this.Codice_diga = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statoKeepAlive = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.gb_keepAlive.SuspendLayout();
            this.tb_diga.SuspendLayout();
            this.tb_keepAlive.SuspendLayout();
            this.tb_manutenzione.SuspendLayout();
            this.gb_Diagnostica.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmr_keepAlive
            // 
            this.tmr_keepAlive.Interval = 15000;
            this.tmr_keepAlive.Tick += new System.EventHandler(this.tmr_keepAlive_Tick);
            // 
            // gb_keepAlive
            // 
            this.gb_keepAlive.Controls.Add(this.btn_start);
            this.gb_keepAlive.Controls.Add(this.btn_stop);
            this.gb_keepAlive.Location = new System.Drawing.Point(7, 7);
            this.gb_keepAlive.Margin = new System.Windows.Forms.Padding(4);
            this.gb_keepAlive.Name = "gb_keepAlive";
            this.gb_keepAlive.Padding = new System.Windows.Forms.Padding(4);
            this.gb_keepAlive.Size = new System.Drawing.Size(400, 107);
            this.gb_keepAlive.TabIndex = 3;
            this.gb_keepAlive.TabStop = false;
            this.gb_keepAlive.Text = "Controlla keep alive";
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
            // tb_diga
            // 
            this.tb_diga.Controls.Add(this.tb_keepAlive);
            this.tb_diga.Controls.Add(this.tb_manutenzione);
            this.tb_diga.Location = new System.Drawing.Point(12, 24);
            this.tb_diga.Name = "tb_diga";
            this.tb_diga.SelectedIndex = 0;
            this.tb_diga.Size = new System.Drawing.Size(428, 321);
            this.tb_diga.TabIndex = 8;
            // 
            // tb_keepAlive
            // 
            this.tb_keepAlive.Controls.Add(this.lv_sinottico);
            this.tb_keepAlive.Controls.Add(this.gb_keepAlive);
            this.tb_keepAlive.Location = new System.Drawing.Point(4, 25);
            this.tb_keepAlive.Name = "tb_keepAlive";
            this.tb_keepAlive.Padding = new System.Windows.Forms.Padding(3);
            this.tb_keepAlive.Size = new System.Drawing.Size(420, 292);
            this.tb_keepAlive.TabIndex = 0;
            this.tb_keepAlive.Text = "Keep alive";
            this.tb_keepAlive.UseVisualStyleBackColor = true;
            // 
            // tb_manutenzione
            // 
            this.tb_manutenzione.Controls.Add(this.gb_Diagnostica);
            this.tb_manutenzione.Location = new System.Drawing.Point(4, 25);
            this.tb_manutenzione.Name = "tb_manutenzione";
            this.tb_manutenzione.Padding = new System.Windows.Forms.Padding(3);
            this.tb_manutenzione.Size = new System.Drawing.Size(420, 231);
            this.tb_manutenzione.TabIndex = 1;
            this.tb_manutenzione.Text = "Manutenzione";
            this.tb_manutenzione.UseVisualStyleBackColor = true;
            // 
            // gb_Diagnostica
            // 
            this.gb_Diagnostica.Controls.Add(this.label2);
            this.gb_Diagnostica.Controls.Add(this.label1);
            this.gb_Diagnostica.Controls.Add(this.txt_minutiTimer);
            this.gb_Diagnostica.Controls.Add(this.btn_aggiornaTimer);
            this.gb_Diagnostica.Location = new System.Drawing.Point(7, 17);
            this.gb_Diagnostica.Margin = new System.Windows.Forms.Padding(4);
            this.gb_Diagnostica.Name = "gb_Diagnostica";
            this.gb_Diagnostica.Padding = new System.Windows.Forms.Padding(4);
            this.gb_Diagnostica.Size = new System.Drawing.Size(333, 197);
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
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "minuti";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Inserisci ogni quanto controllare il keep alive";
            // 
            // txt_minutiTimer
            // 
            this.txt_minutiTimer.Location = new System.Drawing.Point(29, 57);
            this.txt_minutiTimer.Margin = new System.Windows.Forms.Padding(4);
            this.txt_minutiTimer.Name = "txt_minutiTimer";
            this.txt_minutiTimer.Size = new System.Drawing.Size(184, 22);
            this.txt_minutiTimer.TabIndex = 3;
            // 
            // btn_aggiornaTimer
            // 
            this.btn_aggiornaTimer.BackColor = System.Drawing.Color.Snow;
            this.btn_aggiornaTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btn_aggiornaTimer.Location = new System.Drawing.Point(29, 106);
            this.btn_aggiornaTimer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_aggiornaTimer.Name = "btn_aggiornaTimer";
            this.btn_aggiornaTimer.Size = new System.Drawing.Size(272, 75);
            this.btn_aggiornaTimer.TabIndex = 0;
            this.btn_aggiornaTimer.Text = "AGGIORNA INTERVALLO";
            this.btn_aggiornaTimer.UseVisualStyleBackColor = false;
            this.btn_aggiornaTimer.Click += new System.EventHandler(this.btn_aggiornaTimer_Click);
            // 
            // lv_sinottico
            // 
            this.lv_sinottico.BackColor = System.Drawing.Color.Snow;
            this.lv_sinottico.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codice_diga,
            this.statoKeepAlive});
            this.lv_sinottico.HideSelection = false;
            this.lv_sinottico.Location = new System.Drawing.Point(77, 121);
            this.lv_sinottico.Name = "lv_sinottico";
            this.lv_sinottico.Size = new System.Drawing.Size(268, 165);
            this.lv_sinottico.TabIndex = 10;
            this.lv_sinottico.UseCompatibleStateImageBehavior = false;
            this.lv_sinottico.View = System.Windows.Forms.View.Details;
            // 
            // Codice_diga
            // 
            this.Codice_diga.Text = "Codice diga";
            this.Codice_diga.Width = 141;
            // 
            // statoKeepAlive
            // 
            this.statoKeepAlive.Text = "Keep alive";
            this.statoKeepAlive.Width = 122;
            // 
            // frm_PcCentrale_KeepAlive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 347);
            this.Controls.Add(this.tb_diga);
            this.Name = "frm_PcCentrale_KeepAlive";
            this.Text = "PC Centrale Keep Alive";
            this.Load += new System.EventHandler(this.frm_PcCentrale_KeepAlive_Load);
            this.gb_keepAlive.ResumeLayout(false);
            this.tb_diga.ResumeLayout(false);
            this.tb_keepAlive.ResumeLayout(false);
            this.tb_manutenzione.ResumeLayout(false);
            this.gb_Diagnostica.ResumeLayout(false);
            this.gb_Diagnostica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer tmr_keepAlive;
        private System.Windows.Forms.GroupBox gb_keepAlive;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.TabControl tb_diga;
        private System.Windows.Forms.TabPage tb_keepAlive;
        private System.Windows.Forms.TabPage tb_manutenzione;
        private System.Windows.Forms.GroupBox gb_Diagnostica;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_minutiTimer;
        private System.Windows.Forms.Button btn_aggiornaTimer;
        private System.Windows.Forms.ListView lv_sinottico;
        private System.Windows.Forms.ColumnHeader Codice_diga;
        private System.Windows.Forms.ColumnHeader statoKeepAlive;
    }
}

