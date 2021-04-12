using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kørselslogbog
{
    public partial class Form_udtræk : Form
    {
        SqlConnection con = new SqlConnection("Data Source=WIN-3755O2PKQ95;Initial Catalog=KØRSELSLOGBOG;Integrated Security=True");
      
        public Form_udtræk()
        {
            InitializeComponent();
            Fillcombo();
        }

        public void Fillcombo()
      
            {
            con.Open();
            string query = "Select Ch_ID from Chauffører";
            SqlCommand cmd = new SqlCommand(query,con);
            SqlDataReader dr = cmd.ExecuteReader();

            while(dr.Read())
            {
                comboBox_Ch.Items.Add(dr["Ch_ID"].ToString());
                comboBox_Ch.DisplayMember =(dr["Ch_ID"].ToString());
                comboBox_Ch.ValueMember =(dr["Ch_ID"].ToString());
            }
            }



        public void FillDataGridView()
        { 
            con.Open();

            SqlCommand sqlcmd = new SqlCommand();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            
            cmd.CommandText = "Select * from Entry";
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("Invalid ID");

            }
            else
            {
            }

            con.Close();

        }





    //if (textBox_bilid.Text.Contains(bilid))
    //{
    //    cmd.CommandText = "Select Entry.Entry_nummer, Entry.Bil_ID,Entry.Ch_Navn,Entry.Kørte_km, Bil.Nummerplade," +
    //       " Bil.Bilfabrikat from Entry, Bil" +
    //       " where Entry.Bil_ID = '" + bilid + "'" +
    //       " Group by Entry.Entry_nummer, Entry.Ch_Navn, Entry.Bil_ID, Kørte_km, Bil.Nummerplade, " +
    //       "Bil.Bilfabrikat";

    //}

    //else
    //{
    //    cmd.CommandText = "Select * from Entry";
    //}


    private void button_udtræk_Click(object sender, EventArgs e)
        {
            FillDataGridView();
    
        }

    private void button1_Click(object sender, EventArgs e)
    {
    Opret Menu = new Opret();
    this.Hide();
    Menu.Show();

    }

        private void comboBox_Ch_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "Select Entry.Entry_nummer, Entry.Bil_ID,Entry.Ch_Navn,Entry.Kørte_km, " +
                   " Bil.Bilfabrikat from Entry, Bil" +
                   " where Entry.Ch_ID = '" + comboBox_Ch.SelectedItem + "'" +
                   " Group by Entry.Entry_nummer, Entry.Ch_Navn, Entry.Bil_ID, Kørte_km," +
                   "Bil.Bilfabrikat" ;
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;

            con.Close();

            if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Invalid ID");

                }
            else
            {
            }

                        
        }
    }
}
