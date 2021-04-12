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
using Logbog;
using System.Security.Cryptography.X509Certificates;

namespace Kørselslogbog
{
    
    public partial class KM_Input : Form
    {
        SqlConnection con = new SqlConnection("Data Source=WIN-3755O2PKQ95;Initial Catalog=KØRSELSLOGBOG;Integrated Security=True");

        public KM_Input()
        {
            InitializeComponent();
            
        }

        public void insert()
        {
           
            SqlCommand cmd = new SqlCommand("INSERT INTO Entry VALUES(@Ch_ID,@Ch_Navn,@Bil_ID,@Kørte_km,@Dato)", con);
            cmd.CommandType = CommandType.Text;

            cmd.Parameters.AddWithValue("@Ch_ID", textBox1.Text);
            cmd.Parameters.AddWithValue("@Ch_Navn", textBox3.Text);
            cmd.Parameters.AddWithValue("@Bil_ID", textBox5.Text);
            cmd.Parameters.AddWithValue("@Kørte_km", textBox2.Text);
            cmd.Parameters.AddWithValue("@Dato", dateTimePicker1.Value);
            con.Open();
            int i = cmd.ExecuteNonQuery();

            con.Close();

            if (i != 0)
            {
                MessageBox.Show("Entry er gemt!");
            }
           
        }

        public void cleartextbox()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Opret Menu = new Opret();
            this.Hide();
            Menu.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            insert();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
      
            SqlDataAdapter sda = new SqlDataAdapter("Select Fornavn + ' ' + Efternavn As Chauffør_Navn from Chauffører where Ch_ID ='" + textBox1.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
         
            if (dt.Rows.Count == 1)
            {
                textBox3.Text = dt.Rows[0][0].ToString();
               
            }
            else if (textBox1.Text.Contains(""))
            {
                textBox1.Text = "";
            }
            else
            {
              
                MessageBox.Show("ID not found.Type valid ID");            

            }


        }


        private void textBox5_TextChanged(object sender, EventArgs e)
        {           
            SqlDataAdapter sda = new SqlDataAdapter("Select Nummerplade,Model from Bil where Bil_ID ='" + textBox5.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                textBox4.Text = dt.Rows[0][0].ToString();
                textBox6.Text = dt.Rows[0][1].ToString();
            }
            else if (textBox1.Text.Contains(""))
            {
                textBox5.Text = "";
            }
            else
            {
                //textBox5.Text = "";
                MessageBox.Show("ID not found.Type valid ID");             
            }


        }

       
        private void button3_Click(object sender, EventArgs e)
        {
            cleartextbox();
           
        }

       
    }
}
