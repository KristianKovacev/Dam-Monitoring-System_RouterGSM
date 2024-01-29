using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace PC_Diga_KeepAlive
{
    public partial class frm_pcDigaKeepAlive : Form
    {
        public frm_pcDigaKeepAlive()
        {
            InitializeComponent();
        }

        string numero, codDiga;

        private void frm_pcDigaKeepAlive_Load(object sender, EventArgs e)
        {
            // Il programma parte con la tab manutenzione aperta;
            tb_diga.SelectTab("tb_manutenzione");

            string[] serialPorts = SerialPort.GetPortNames();
            // Aggiungo alle comboBox le porte seriali da scegliere
            cb_serial_ports.Items.AddRange(serialPorts);
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            tmr_keepAlive.Start();
        }

        private void tmr_keepAlive_Tick(object sender, EventArgs e)
        {
            // Controllo se la porta è chiusa
            // Potrebbe esserci un conflitto tra i due processi
            if (!srl_routerGSM.IsOpen)
            {
                srl_routerGSM.Open();
                // La struttura del nostro messaggio sarà "%" + codiceDiga + "ka"
                // Il "%" serve per identificare il nostro messaggio
                // ka sta per keepalive, grazie a questo il server potrà riconoscere
                // che il messaggio che gli stiamo mandando è un keep-alive
                string messaggio = "%" + codDiga + "ka";

                srl_routerGSM.WriteLine(@"AT+CMGF=1" + (char)(13));
                Thread.Sleep(2000);

                srl_routerGSM.WriteLine(@"AT+CMGS=" + numero + (char)(13));
                Thread.Sleep(2000);

                srl_routerGSM.WriteLine(messaggio + (char)(26));

                srl_routerGSM.Close();
            }
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            tmr_keepAlive.Stop();
            gb_Diagnostica.Enabled = true;
        }

        private void btn_startDiagnostica_Click(object sender, EventArgs e)
        {
            // Per la fase di diagnostica
            if (tmr_keepAlive.Enabled)
                MessageBox.Show("Stoppa prima il timer!");
            else if (String.IsNullOrEmpty(txt_millisecondiTimer.Text))
                MessageBox.Show("Inserire l'intervallo di tempo in ms");
            else
                // Cambio l'intervallo del timer
                tmr_keepAlive.Interval = Int32.Parse(txt_millisecondiTimer.Text);
        }

        private void btn_inserisciDatiDiga_Click(object sender, EventArgs e)
        {
            // Vengono aggiornati nella tab manutenzione
            if (String.IsNullOrEmpty(cb_prefisso.Text + txt_numeroServer.Text))
                MessageBox.Show("Inserisci il numero di telefono del server!");
            else if (String.IsNullOrEmpty(txt_codiceDiga.Text))
                MessageBox.Show("Inserisci il codice della diga!");
            else
            {
                numero = cb_prefisso.Text + txt_numeroServer.Text;
                codDiga = txt_codiceDiga.Text;
            }
        }

        private void btn_open_srl_Click(object sender, EventArgs e)
        {
            if (cb_serial_ports.SelectedIndex > -1)
                // Prendo la porta selezionata nella comboBox
                srl_routerGSM.PortName = cb_serial_ports.SelectedItem.ToString();
            else
                MessageBox.Show("Seleziona prima una porta!");
        }
    }
}
