using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;

namespace PC_Diga_Segnale
{
    public partial class frm_pcDigaSegnale : Form
    {
        public frm_pcDigaSegnale()
        {
            InitializeComponent();
        }

        // Numero del server centrale e il codice della diga
        string numero, codDiga;

        private void frm_pcDigaSegnale_Load(object sender, EventArgs e)
        {
            // Il programma parte con la tab manutenzione aperta;
            tb_diga.SelectTab("tb_manutenzione");

            string[] serialPorts = SerialPort.GetPortNames();
            // Aggiungo alle comboBox le porte seriali da scegliere
            cb_serial_ports.Items.AddRange(serialPorts);
        }

        private void btn_open_srl_Click(object sender, EventArgs e)
        {
            if (cb_serial_ports.SelectedIndex > -1)
            {
                // Prendo la porta selezionata nella comboBox
                srl_routerGSM.PortName = cb_serial_ports.SelectedItem.ToString();
                gb_simulazioneSensore.Enabled = true;
            }
            else
                MessageBox.Show("Seleziona prima una porta!");
        }

        private void sendMessage(string statoDiga)
        {
            // La porta viene aperta  e chiusa ogni volta che dobbiamo mandare un messaggio
            srl_routerGSM.Open();

            // La struttura del nostro messaggio sarà "%" + codiceDiga + stato diga
            // Il percento serve per identificare il messaggio, quando il router del server centrale
            // legge quello che c'è nel buffer legge anche tutti i comandi AT e le date 
            // quindi abbiamo bisogno di identificare il messaggio
            // Preallerta = 1
            // Allerta = 2
            string messaggio = "%" + codDiga + statoDiga;

            // Comandi per mandare il messaggio attraverso il router GSM
            srl_routerGSM.WriteLine(@"AT+CMGF=1" + (char)(13)); 
            Thread.Sleep(2000);

            // Invio del numero a cui inviare il messaggio
            srl_routerGSM.WriteLine(@"AT+CMGS=" + numero + (char)(13));
            Thread.Sleep(2000);

            // Aggiungo testo del messaggio e invio
            srl_routerGSM.WriteLine(messaggio + (char)(26));

            // Chiudo la porta, per permettere ad altri processi (keep-alive) di utilizzarla
            srl_routerGSM.Close();
        }

        private void btn_Preallerta_Click(object sender, EventArgs e)
        {
            // 1 = preallerta
            string statoDiga = "1";
            sendMessage(statoDiga);

            // Aggiorno sinottico
            lbl_statoDiga.BackColor = System.Drawing.Color.DarkOrange;
            lbl_statoDiga.Text = "PREALLERTA";
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
                // Numero di telefono del server centrale
                numero = cb_prefisso.Text + txt_numeroServer.Text;
                codDiga = txt_codiceDiga.Text;
            }
        }

        private void btn_allerta_Click(object sender, EventArgs e)
        {
            // 2 = allerta
            string statoDiga = "2";
            sendMessage(statoDiga);

            // Aggiorno sinottico
            lbl_statoDiga.BackColor = System.Drawing.Color.Red;
            lbl_statoDiga.Text = "ALLERTA";
        }
        
    }
}
