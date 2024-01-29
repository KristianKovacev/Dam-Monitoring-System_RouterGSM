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

namespace PC_Centrale_KeepAlive
{
    public partial class frm_PcCentrale_KeepAlive : Form
    {
        public frm_PcCentrale_KeepAlive()
        {
            InitializeComponent();
        }

        private readonly string digaConnectionString = "Data Source = (local); Initial Catalog = Diga; Integrated Security = True";
        
        List<string> lista_idDighe = new List<string>();
        int minuti = 60;

        private void btn_start_Click(object sender, EventArgs e)
        {
            tmr_keepAlive.Start();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            tmr_keepAlive.Stop();
        }

        private void tmr_keepAlive_Tick(object sender, EventArgs e)
        {
            // Prendo l'ultimo keep-alive ricevuto di ogni diga e 
            // faccio il controllo per vedere se è arrivato nell'ultima ora
            string query = "SELECT TOP 1 Dighe.CodiceDiga, Data FROM KeepAlive " +
                           "INNER JOIN dbo.Dighe ON KeepAlive.IdDiga = Dighe.IdDiga " +
                           "WHERE KeepAlive.IdDiga = @IdDiga " +
                           "ORDER BY Data DESC";

            // Per ogni diga viene controllato l'ultimo keep alive
            foreach (string idDiga in lista_idDighe)
            {
                Console.WriteLine(idDiga);
                // Per evitare la SQL Injection
                SqlParameter parIdDiga = new SqlParameter();
                parIdDiga.ParameterName = "@IdDiga";
                parIdDiga.Value = idDiga;

                esecuzioneQuery(query, true, parIdDiga);
            }
        }

        public void esecuzioneQuery(string query, bool tipoQuery, SqlParameter parametro)
        {
            using (SqlConnection connection = new SqlConnection(digaConnectionString))
            {
                try
                {
                    SqlCommand cmd = new SqlCommand(query, connection);
                    connection.Open();
                    
                    // Vuol dire che viene fatta la select sulla data
                    if (tipoQuery)
                    {
                        cmd.Parameters.Add(parametro);
                        SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        while (reader.Read())
                        {
                            // Prendo dal reader la data
                            DateTime data = DateTime.Parse(reader["Data"].ToString());
                            // Faccio la differenza tra la data attuale e la data dell'ultimo keep alive ricevuto
                            TimeSpan diff = DateTime.Now.Subtract(data); 
                            double diffMinuti = Convert.ToDouble(diff.TotalMinutes);
                            
                            // Se sono passati più di 60 minuti dall'ultimo keep alive segnalo
                            if (diffMinuti > minuti)
                            {
                                ListViewItem lvItem = new ListViewItem(new string[] { reader["CodiceDiga"].ToString(), "NO KEEP-ALIVE" });
                                lv_sinottico.Items.Add(lvItem);
                                //MessageBox.Show("La diga " + reader["CodiceDiga"].ToString() + " non riceve il keep alive");
                            }

                        }
                    }
                    // Vuol dire che viene preso il codice di ogni diga
                    else
                    {
                        SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                        while (reader.Read())
                        {
                            // Aggiungo alla lista idDighe tutti gli id delle dighe
                            lista_idDighe.Add(reader["IdDiga"].ToString());
                        }
                    }
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

        private void btn_aggiornaTimer_Click(object sender, EventArgs e)
        {
            // Controlli per evitare che il programma si blocchi
            if (tmr_keepAlive.Enabled)
                MessageBox.Show("Stoppa prima il timer!");

            else if (String.IsNullOrEmpty(txt_minutiTimer.Text) ||
                     !int.TryParse(txt_minutiTimer.Text, out int a))
                MessageBox.Show("Inserire l'intervallo di tempo in minuti");
            else
            {
                // L'utente inserisci i minuti noi li convertiamo in millisecondi
                int millisecondi = Convert.ToInt32(TimeSpan.FromMinutes(Convert.ToDouble(txt_minutiTimer.Text)).TotalMilliseconds);
                tmr_keepAlive.Interval = millisecondi;

                // La variabile minuti serve per controllare che il keep alive
                // sia arrivato prima di questi minuti (keepalive < minuti ?)
                minuti = Convert.ToInt32(txt_minutiTimer.Text);
            }
        }

        private void frm_PcCentrale_KeepAlive_Load(object sender, EventArgs e)
        {
            // Il programma parte con la tab manutenzione aperta;
            tb_diga.SelectTab("tb_manutenzione");

            // Prendo gli id di tutte le dighe presenti
            string query = "SELECT IdDiga FROM dbo.Dighe";

            esecuzioneQuery(query, false, null);
        }
    }
}
