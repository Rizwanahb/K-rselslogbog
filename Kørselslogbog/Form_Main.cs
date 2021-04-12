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

namespace Kørselslogbog
{
    public partial class Opret : Form
    {
        SqlConnection con = new SqlConnection("Data Source=WIN-3755O2PKQ95;Initial Catalog=KØRSELSLOGBOG;Integrated Security=True");
        public Opret()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_Chauffør opret = new Form_Chauffør();
            opret.Show();

        }

        private void b_KMINPUT_Click(object sender, EventArgs e)
        {
            this.Hide();
            KM_Input km = new KM_Input();
            km.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void b_UDTRÆK_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_udtræk fu = new Form_udtræk();
            fu.Show();

        }

        private void b_RETTE_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_bil bil = new Form_bil();
            bil.Show();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

     

