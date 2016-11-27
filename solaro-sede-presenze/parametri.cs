using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace solaro_sede_presenze
{
    public partial class parametri : Form
    {
        public parametri()
        {
            InitializeComponent();
        }

        private void parametri_Load(object sender, EventArgs e)
        {
            tbxIPsolaro1Remoto.Text = solaro_sede_presenze.Properties.Settings.Default.ip_solaro1;
            tbxPercorsoSolaro1Remoto.Text = solaro_sede_presenze.Properties.Settings.Default.connessione_solaro1_remota;
            tbxIpSolaro2Remoto.Text = solaro_sede_presenze.Properties.Settings.Default.ip_solaro2;
            tbxPercorsoSolaro2Remoto.Text = solaro_sede_presenze.Properties.Settings.Default.connessione_solaro2_remota;
            tbxIPsolaro1Locale.Text = solaro_sede_presenze.Properties.Settings.Default.ip_solaro1_locale;
            tbxPercorsoSolaro1Locale.Text = solaro_sede_presenze.Properties.Settings.Default.connessione_solaro1_locale;
            tbxIPsolaro2Locale.Text = solaro_sede_presenze.Properties.Settings.Default.ip_solaro2_locale;
            tbxPercorsoSolaro2Locale.Text = solaro_sede_presenze.Properties.Settings.Default.connessione_solaro2_locale;
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            solaro_sede_presenze.Properties.Settings.Default.ip_solaro1= tbxIPsolaro1Remoto.Text;
            solaro_sede_presenze.Properties.Settings.Default.connessione_solaro1_remota=tbxPercorsoSolaro1Remoto.Text;
            solaro_sede_presenze.Properties.Settings.Default.ip_solaro2=tbxIpSolaro2Remoto.Text;
            solaro_sede_presenze.Properties.Settings.Default.connessione_solaro2_remota = tbxPercorsoSolaro2Remoto.Text;
            solaro_sede_presenze.Properties.Settings.Default.ip_solaro1_locale=tbxIPsolaro1Locale.Text;
            solaro_sede_presenze.Properties.Settings.Default.connessione_solaro1_locale =  tbxPercorsoSolaro1Locale.Text;
            solaro_sede_presenze.Properties.Settings.Default.ip_solaro2_locale          =  tbxIPsolaro2Locale.Text;
            solaro_sede_presenze.Properties.Settings.Default.connessione_solaro2_locale =  tbxPercorsoSolaro2Locale.Text;
            solaro_sede_presenze.Properties.Settings.Default.Save();
            this.Close();

        }
    }
}
