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
    public partial class password : Form
    {
        public password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="tronco-importa")
            {
                Form parametri = new parametri();
                parametri.Show();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }
            
    }
}
