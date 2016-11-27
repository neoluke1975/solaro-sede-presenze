using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebirdSql.Data.FirebirdClient;

namespace solaro_sede_presenze
{
    public partial class Form1 : Form
    {
        FbConnection connessione_solaro1_remota = new FbConnection("User=SYSDBA;Password=masterkey;Database="+solaro_sede_presenze.Properties.Settings.Default.connessione_solaro1_remota+";DataSource="+solaro_sede_presenze.Properties.Settings.Default.ip_solaro1+";Port = 3050; Dialect=1;Charset=NONE;Role=;Connection lifetime = 15; Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size = 8192; ServerType=0;");
        FbConnection connessione_solaro1_locale = new FbConnection("User=SYSDBA;Password=masterkey;Database="+solaro_sede_presenze.Properties.Settings.Default.connessione_solaro1_locale+";DataSource="+solaro_sede_presenze.Properties.Settings.Default.ip_solaro1_locale+";Port = 3050; Dialect=1;Charset=NONE;Role=;Connection lifetime = 15; Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size = 8192; ServerType=0;");
        FbConnection connessione_solaro2_remota = new FbConnection("User=SYSDBA;Password=masterkey;Database=" + solaro_sede_presenze.Properties.Settings.Default.connessione_solaro2_remota + ";DataSource=" + solaro_sede_presenze.Properties.Settings.Default.ip_solaro2 + ";Port = 3050; Dialect=1;Charset=NONE;Role=;Connection lifetime = 15; Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size = 8192; ServerType=0;");
        FbConnection connessione_solaro2_locale = new FbConnection("User=SYSDBA;Password=masterkey;Database=" + solaro_sede_presenze.Properties.Settings.Default.connessione_solaro2_locale + ";DataSource=" + solaro_sede_presenze.Properties.Settings.Default.ip_solaro2_locale + ";Port = 3050; Dialect=1;Charset=NONE;Role=;Connection lifetime = 15; Pooling=true;MinPoolSize=0;MaxPoolSize=50;Packet Size = 8192; ServerType=0;");

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSolaro1_Click(object sender, EventArgs e)
        {
            if (btnControlloConnesione.BackColor == Color.LightGreen)
            {
                try
                {
                    connessione_solaro1_remota.Open();
                    FbCommand query_operatori_solaro1 = new FbCommand("select o.CODICE,o.NOMINATIVO,o.BARCODE,o.ultimo_ip,case when o.ULTIMO_UTILIZZO is not null then f_Month(o.ultimo_utilizzo) || '/' || f_DAYOFMONTH(o.ultimo_utilizzo) || '/' || f_year(o.ultimo_utilizzo)" +
                                                                                                                 " when o.ultimo_utilizzo is null then \"\" end, " +
                                                                      "o.IMMAGINE,o.PER_TE,o.ATTIVO,o.DATA_SCADENZA,o.PSW,o.ORA_INIZIO,o.ORA_FINE,o.GRUPPO,o.AGG_WG,o.WFE_WIFI," +
                                                                      "o.COD_FISC,o.DA_SEDE from operatori o", connessione_solaro1_remota);
                    FbDataReader lettore = query_operatori_solaro1.ExecuteReader();
                    connessione_solaro1_locale.Open();
                    FbCommand cancella = new FbCommand("delete from operatori", connessione_solaro1_locale);
                    cancella.ExecuteNonQuery();
                    FbCommand query_presenze = new FbCommand("select f_Month(p.data) || '/' || f_DAYOFMONTH(p.data) || '/' || f_year(p.data)," +
                                                       "p.ora," +
                                                       "p.operatore," +
                                                       "p.descrizione," +
                                                       "p.note," +
                                                       "p.FESTIVO,  " +
                                                       "p.FERIE,    " +
                                                       "p.MALATTIA, " +
                                                       "p.FLAG_1,   " +
                                                       "p.FLAG_2,   " +
                                                       "p.FLAG_3,   " +
                                                       "p.RIPOSO,   " +
                                                       "p.PERMESSO  " +
                                                       "from PRESENZE p", connessione_solaro1_remota);
                    FbDataReader lettore_presenze = query_presenze.ExecuteReader();

                    while (lettore.Read())
                    {

                        int codice = int.Parse(lettore[0].ToString());
                        string nome_operatore = lettore[1].ToString();
                        string barcode = lettore[2].ToString();
                        string ultimo_ip = lettore[3].ToString();

                        string ultimo_utilizzo = "'" + lettore[4].ToString().Replace(" ", "") + "'";
                        if (ultimo_utilizzo == "''")
                        {
                            ultimo_utilizzo = "NULL";
                        }
                        string immagine = lettore[5].ToString();
                        string per_te = lettore[6].ToString();
                        string attivo = lettore[7].ToString();
                        string datascadenza = lettore[8].ToString();
                        string psw = lettore[9].ToString();
                        int gruppo = int.Parse(lettore[12].ToString());
                        string agg_wg = lettore[13].ToString();
                        string codicefiscale = lettore[15].ToString();
                        string da_sede = lettore[16].ToString();
                        
                        FbCommand inserimento_operatori_solaro1 = new FbCommand("INSERT INTO OPERATORI (CODICE,NOMINATIVO,BARCODE,ULTIMO_IP,ULTIMO_UTILIZZO,IMMAGINE,PER_TE,ATTIVO,DATA_SCADENZA,PSW,ORA_INIZIO,ORA_FINE,GRUPPO,AGG_WG,WFE_WIFI,COD_FISC,DA_SEDE)  values " +
                                                                              "('" + codice + "','" + nome_operatore + "','" +
                                                                                 barcode + "','" + ultimo_ip + "'," +
                                                                                 ultimo_utilizzo + ",'" + immagine + "','" +
                                                                                 per_te + "','" + attivo + "','" +
                                                                                 datascadenza + "','" + psw + "'," +
                                                                                 "'00:00:00','23:59:59','" +
                                                                                 gruppo + "','" + agg_wg + "',NULL,'" +
                                                                                 codicefiscale + "','" + da_sede + "');", connessione_solaro1_locale);

                        inserimento_operatori_solaro1.ExecuteNonQuery();
                    }
                    FbCommand delete_presenze = new FbCommand("delete from presenze", connessione_solaro1_locale);
                    delete_presenze.ExecuteNonQuery();
                    while (lettore_presenze.Read())
                    {
                        string data = "'" + lettore_presenze[0].ToString() + "'";
                        string ora = "'"+lettore_presenze[1].ToString()+"'";
                        int operatore = int.Parse(lettore_presenze[2].ToString());
                        string descrizione = "'" + lettore_presenze[3].ToString()+"'";
                        string note = "'" + lettore_presenze[4].ToString() + "'";
                        string festivo = "'" + lettore_presenze[5].ToString() + "'";
                        string ferie = "'" + lettore_presenze[6].ToString() + "'";
                        string malattia = "'" + lettore_presenze[7].ToString() + "'";
                        string flag_1 = "'" + lettore_presenze[8].ToString() + "'";
                        string flag_2 = "'" + lettore_presenze[9].ToString() + "'";
                        string flag_3 = "'" + lettore_presenze[10].ToString() + "'";
                        string riposo = "'" + lettore_presenze[11].ToString() + "'";
                        string permesso = "'" + lettore_presenze[12].ToString() + "'";

                        FbCommand inserimento_presenze = new FbCommand("INSERT INTO PRESENZE (DATA, ORA, OPERATORE, DESCRIZIONE, NOTE, FESTIVO, FERIE, MALATTIA, FLAG_1, FLAG_2, FLAG_3, RIPOSO, PERMESSO) VALUES "+
                                                           "("+data+","+ora+","+operatore+","+descrizione+","+note+","+festivo+","+ferie+","+malattia+","+flag_1+","+flag_2+","+flag_3+","+riposo+","+permesso+");", connessione_solaro1_locale);

                        inserimento_presenze.ExecuteNonQuery();
                    }
                    connessione_solaro1_locale.Close();
                    connessione_solaro1_remota.Close();
                    lettore_presenze.Close();
                    lettore.Close();
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else if(btnControlloConnesione.BackColor != Color.LightGreen)
            {
                MessageBox.Show("Controlla Connessione");
            }
        }

        private void btnControlloConnesione_Click(object sender, EventArgs e)
        {
            try
            {
                connessione_solaro1_remota.Open();
                btnControlloConnesione.BackColor = Color.LightGreen;
                btnControlloConnesione.Enabled = false;
            }
            catch (Exception)
            {

                btnControlloConnesione.BackColor = Color.Red;
            }
            connessione_solaro1_remota.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Form password = new password();
            password.Show();
                

        }

        private void btnConnessioneSolaro2_Click(object sender, EventArgs e)
        {
            try
            {
                connessione_solaro2_remota.Open();
                btnConnessioneSolaro2.BackColor = Color.LightGreen;
                btnConnessioneSolaro2.Enabled = false;
            }
            catch (Exception)
            {

                btnConnessioneSolaro2.BackColor = Color.Red;
            }
            connessione_solaro2_remota.Close();

        }

        private void btnSolaro2_Click(object sender, EventArgs e)
        {
            if (btnControlloConnesione.BackColor == Color.LightGreen)
            {
                try
                {
                    connessione_solaro2_remota.Open();
                    FbCommand query_operatori_solaro2 = new FbCommand("select o.CODICE,o.NOMINATIVO,o.BARCODE,o.ultimo_ip,case when o.ULTIMO_UTILIZZO is not null then f_Month(o.ultimo_utilizzo) || '/' || f_DAYOFMONTH(o.ultimo_utilizzo) || '/' || f_year(o.ultimo_utilizzo)" +
                                                                                                                 " when o.ultimo_utilizzo is null then \"\" end, " +
                                                                      "o.IMMAGINE,o.PER_TE,o.ATTIVO,o.DATA_SCADENZA,o.PSW,o.ORA_INIZIO,o.ORA_FINE,o.GRUPPO,o.AGG_WG,o.WFE_WIFI," +
                                                                      "o.COD_FISC,o.DA_SEDE from operatori o", connessione_solaro2_remota);
                    FbDataReader lettore = query_operatori_solaro2.ExecuteReader();
                    connessione_solaro2_locale.Open();
                    FbCommand cancella = new FbCommand("delete from operatori", connessione_solaro2_locale);
                    cancella.ExecuteNonQuery();
                    FbCommand query_presenze = new FbCommand("select f_Month(p.data) || '/' || f_DAYOFMONTH(p.data) || '/' || f_year(p.data)," +
                                                       "p.ora," +
                                                       "p.operatore," +
                                                       "p.descrizione," +
                                                       "p.note," +
                                                       "p.FESTIVO,  " +
                                                       "p.FERIE,    " +
                                                       "p.MALATTIA, " +
                                                       "p.FLAG_1,   " +
                                                       "p.FLAG_2,   " +
                                                       "p.FLAG_3,   " +
                                                       "p.RIPOSO,   " +
                                                       "p.PERMESSO  " +
                                                       "from PRESENZE p", connessione_solaro2_remota);
                    FbDataReader lettore_presenze = query_presenze.ExecuteReader();

                    while (lettore.Read())
                    {

                        int codice = int.Parse(lettore[0].ToString());
                        string nome_operatore = lettore[1].ToString();
                        string barcode = lettore[2].ToString();
                        string ultimo_ip = lettore[3].ToString();

                        string ultimo_utilizzo = "'" + lettore[4].ToString().Replace(" ", "") + "'";
                        if (ultimo_utilizzo == "''")
                        {
                            ultimo_utilizzo = "NULL";
                        }
                        string immagine = lettore[5].ToString();
                        string per_te = lettore[6].ToString();
                        string attivo = lettore[7].ToString();
                        string datascadenza = lettore[8].ToString();
                        string psw = lettore[9].ToString();
                        int gruppo = int.Parse(lettore[12].ToString());
                        string agg_wg = lettore[13].ToString();
                        string codicefiscale = lettore[15].ToString();
                        string da_sede = lettore[16].ToString();

                        FbCommand inserimento_operatori_solaro2 = new FbCommand("INSERT INTO OPERATORI (CODICE,NOMINATIVO,BARCODE,ULTIMO_IP,ULTIMO_UTILIZZO,IMMAGINE,PER_TE,ATTIVO,DATA_SCADENZA,PSW,ORA_INIZIO,ORA_FINE,GRUPPO,AGG_WG,WFE_WIFI,COD_FISC,DA_SEDE)  values " +
                                                                              "('" + codice + "','" + nome_operatore + "','" +
                                                                                 barcode + "','" + ultimo_ip + "'," +
                                                                                 ultimo_utilizzo + ",'" + immagine + "','" +
                                                                                 per_te + "','" + attivo + "','" +
                                                                                 datascadenza + "','" + psw + "'," +
                                                                                 "'00:00:00','23:59:59','" +
                                                                                 gruppo + "','" + agg_wg + "',NULL,'" +
                                                                                 codicefiscale + "','" + da_sede + "');", connessione_solaro2_locale);

                        inserimento_operatori_solaro2.ExecuteNonQuery();
                    }
                    FbCommand delete_presenze = new FbCommand("delete from presenze", connessione_solaro2_locale);
                    delete_presenze.ExecuteNonQuery();
                    while (lettore_presenze.Read())
                    {
                        string data = "'" + lettore_presenze[0].ToString() + "'";
                        string ora = "'" + lettore_presenze[1].ToString() + "'";
                        int operatore = int.Parse(lettore_presenze[2].ToString());
                        string descrizione = "'" + lettore_presenze[3].ToString() + "'";
                        string note = "'" + lettore_presenze[4].ToString() + "'";
                        string festivo = "'" + lettore_presenze[5].ToString() + "'";
                        string ferie = "'" + lettore_presenze[6].ToString() + "'";
                        string malattia = "'" + lettore_presenze[7].ToString() + "'";
                        string flag_1 = "'" + lettore_presenze[8].ToString() + "'";
                        string flag_2 = "'" + lettore_presenze[9].ToString() + "'";
                        string flag_3 = "'" + lettore_presenze[10].ToString() + "'";
                        string riposo = "'" + lettore_presenze[11].ToString() + "'";
                        string permesso = "'" + lettore_presenze[12].ToString() + "'";

                        FbCommand inserimento_presenze = new FbCommand("INSERT INTO PRESENZE (DATA, ORA, OPERATORE, DESCRIZIONE, NOTE, FESTIVO, FERIE, MALATTIA, FLAG_1, FLAG_2, FLAG_3, RIPOSO, PERMESSO) VALUES " +
                                                           "(" + data + "," + ora + "," + operatore + "," + descrizione + "," + note + "," + festivo + "," + ferie + "," + malattia + "," + flag_1 + "," + flag_2 + "," + flag_3 + "," + riposo + "," + permesso + ");", connessione_solaro2_locale);

                        inserimento_presenze.ExecuteNonQuery();
                    }
                    connessione_solaro2_locale.Close();
                    connessione_solaro2_remota.Close();
                    lettore.Close();
                    lettore_presenze.Close();

                }
                catch (Exception)
                {

                    throw;
                }
            }
            else if (btnControlloConnesione.BackColor != Color.LightGreen)
            {
                MessageBox.Show("Controlla Connessione");
            }
        }
    }
    }
    
