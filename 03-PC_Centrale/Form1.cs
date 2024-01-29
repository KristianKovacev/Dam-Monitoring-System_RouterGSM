using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO.Ports;
using System.Threading;

namespace PC_Centrale
{
    public partial class frm_pcCentrale : Form
    {
        public frm_pcCentrale()
        {
            InitializeComponent();
        }

        // stringa di connessione
        private readonly string digaConnectionString = "Data Source = (local); Initial Catalog = Diga; Integrated Security = True";

        private void srl_routerGSM_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            try
            {
                // Per evitare i problemi di cross-thread
                Invoke(new Action(() =>
                {
                    // Leggo il messaggio dal buffer
                    string messaggioRicevuto = srl_routerGSM.ReadExisting();

                    // Il messaggio è costituito nel seguente modo:
                    // "%" + codiceDiga + statoDiga ("%011") o
                    // "%" + codiceDiga + "ka" ("%01ka")

                    // Vedo in quale posizione inizia il nostro messaggio
                    int indexPercento = messaggioRicevuto.IndexOf("%");
                    // Dalla stringa estraggo il messaggio che ci interessa
                    messaggioRicevuto = messaggioRicevuto.Substring(indexPercento, 5);

                    // Prendo il codice della diga dal messaggio ricevuto
                    string codiceDiga = messaggioRicevuto.Substring(1, 2);

                    string query;
                    // Mi serve per gestire i parametri per la SQL injection
                    List<SqlParameter> parametri = new List<SqlParameter>();

                    // Se il messaggio contiene la parola ka (keep alive)
                    // vuol dire che è un keep-alive
                    if (messaggioRicevuto.Contains("ka"))
                    {
                        // Inserisco nella tabella keep-alive che ho appena ricevuto il record
                        // questa informazione servirà all'altro processo per verificare
                        // che il keep-alive sia arrivato nell'ultima ora
                        query = "INSERT INTO KeepAlive(IdDiga, Data) " +
                                "SELECT IdDiga, GETDATE() FROM dbo.Dighe " +
                                "WHERE CodiceDiga = @codiceDiga";
                    }
                    // Sennò è un messaggio per aggiornare lo stato della diga
                    else
                    {
                        // Estraggo dal messaggio lo stato della diga
                        string statoDiga = messaggioRicevuto.Substring(3, 1);

                        AggiornaSinottico(codiceDiga, statoDiga);

                        // Inserisco il nuovo stato della diga nel database
                        query = "INSERT INTO StatoDiga(IdDiga, StatoDiga, Data) " +
                                "SELECT IdDiga, @statoDiga, GETDATE() FROM dbo.Dighe " +
                                "WHERE CodiceDiga = @codiceDiga";

                        // Parametri per la SQL injection
                        SqlParameter parStatoDiga = new SqlParameter();
                        parStatoDiga.ParameterName = "@statoDiga";
                        parStatoDiga.Value = statoDiga;
                        parametri.Add(parStatoDiga);
                    }
                    // Questo parametro sarà presente in entrambe le query quindi è "globale"
                    SqlParameter parCodiceDiga = new SqlParameter();
                    parCodiceDiga.ParameterName = "@codiceDiga";
                    parCodiceDiga.Value = codiceDiga;
                    parametri.Add(parCodiceDiga);

                    esecuzioneQuery(query, parametri);
                }));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_open_srl_Click(object sender, EventArgs e)
        {
            // Apro la porta
            // La porta resterà sempre aperta deve rimanere in ascolto
            if (cb_serial_ports.SelectedIndex > -1)
            {
                srl_routerGSM.PortName = cb_serial_ports.SelectedItem.ToString();
                srl_routerGSM.Open();
                lbl_stato_porta.Text = "PORTA: ON";

                // Faccio partire il timer
                //tmr_leggiMessaggi.Start();
            }
            else
                MessageBox.Show("Seleziona una porta!");
        }

        private void btn_closeSrl_Click(object sender, EventArgs e)
        {
            // Chiudo la porta, serve per quando l'operatore dovrà fare manutenzione
            if (cb_serial_ports.SelectedIndex > -1)
            {
                srl_routerGSM.Close();
                lbl_stato_porta.Text = "PORTA: OFF";
            }
            else
                MessageBox.Show("Seleziona una porta!");
        }

        public void esecuzioneQuery(string query, List<SqlParameter> parametri)
        {
            // Eseguo la query
            using (SqlConnection connection = new SqlConnection(digaConnectionString)) 
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, connection);

                    // Parametri per evitare la SQL injection
                    parametri.ForEach(parametro => { cmd.Parameters.Add(parametro); });

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Eccezione Database");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Eccezione generica");
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void AggiornaSinottico(string codiceDiga, string statoDiga)
        {
            // Aggiungo il record
            ListViewItem lvItem = new ListViewItem(new string[] { codiceDiga, statoDiga });
            lv_sinottico.Items.Add(lvItem);
        }

        private void frm_pcCentrale_Load(object sender, EventArgs e)
        {
            // Il programma parte con la tab manutenzione aperta;
            tb_diga.SelectTab("tb_manutenzione");

            string[] serialPorts = SerialPort.GetPortNames();
            // Aggiungo alle comboBox le porte seriali da scegliere
            cb_serial_ports.Items.AddRange(serialPorts);
        }

        private void tmr_leggiMessaggi_Tick(object sender, EventArgs e)
        {
            // Svuoto il buffer
            // IMPORTANTE: il buffer deve essere vuoto, questo comando cancella solo l'ultimo messaggio
            // In questo modo andremo a leggere l'ultimo messaggio ricevuto
            srl_routerGSM.WriteLine(@"AT+CMGD=1" + (char)(13));
            Thread.Sleep(2000);

            // Comandi per leggere i messaggi contenuti nel buffer
            srl_routerGSM.WriteLine(@"AT+CMGF=1" + (char)(13));
            Thread.Sleep(2000);

            // Leggo tutti gli SMS in memoria
            srl_routerGSM.WriteLine(@"AT+CMGL=ALL" + (char)(13));
            Thread.Sleep(2000);
        }

        private void btn_leggi_Click(object sender, EventArgs e)
        {
            // Svuoto il buffer
            // IMPORTANTE: il buffer deve essere vuoto, questo comando cancella solo l'ultimo messaggio
            // In questo modo andremo a leggere l'ultimo messaggio ricevuto
            srl_routerGSM.WriteLine(@"AT+CMGD=1" + (char)(13));
            Thread.Sleep(2000);

            // Comandi per leggere i messaggi contenuti nel buffer
            srl_routerGSM.WriteLine(@"AT+CMGF=1" + (char)(13));
            Thread.Sleep(2000);

            // Leggo tutti gli SMS in memoria
            srl_routerGSM.WriteLine(@"AT+CMGL=ALL" + (char)(13));
            Thread.Sleep(2000);
        }
    }
}
