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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
            

        }
        

        private void button3_Click(object sender, EventArgs e)
        {
            FbConnection connesione_solaro1_remota = new FbConnection("User=SYSDBA;Password=masterkey;Database="+textBox1.Text+";DataSource="+textBox3.Text+";Port = 3050; Dialect = 1; Charset = NONE; Role =; Connection lifetime = 15; Pooling = true;MinPoolSize = 0; MaxPoolSize = 50; Packet Size = 8192; ServerType = 0; ");
            try
            {
                connesione_solaro1_remota.Open();
                MessageBox.Show("connessione alla comunale 1 ok");
                connesione_solaro1_remota.Close();
                button3.BackColor = Color.Green;
            }
            catch (Exception)
            {

                MessageBox.Show("connessione alla comunale 1 non presente");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FbConnection connesione_solaro2_remota = new FbConnection("User=SYSDBA;Password=masterkey;Database=" + textBox2.Text + ";DataSource=" + textBox4.Text + ";Port = 3050; Dialect = 1; Charset = NONE; Role =; Connection lifetime = 15; Pooling = true;MinPoolSize = 0; MaxPoolSize = 50; Packet Size = 8192; ServerType = 0; ");
            try
            {
                connesione_solaro2_remota.Open();
                MessageBox.Show("connessione alla comunale 2 ok");
                connesione_solaro2_remota.Close();
                button4.BackColor = Color.Green;
            }
            catch (Exception)
            {

                MessageBox.Show("connessione alla comunale 2 non presente");
            }
        }

        
    }
    }
