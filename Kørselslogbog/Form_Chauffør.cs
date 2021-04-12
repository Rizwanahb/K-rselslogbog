using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Logbog.DataAccess;
using Logbog.Model;
using System.Data.SqlClient;

namespace Kørselslogbog
{
    public partial class Form_Chauffør : Form
    {
        private Chauffør CurrentChauffør;
        public Form_Chauffør()
        {
            InitializeComponent();
        }

        private void button_Mainmenu_Click(object sender, EventArgs e)
        {
            Opret Menu = new Opret();
            this.Close();
            Menu.Show();

        }

        private void but_Gem_Click(object sender, EventArgs e)
        {
           
            try
            {
                if (IsCustomerNameValid())
                {
                    CurrentChauffør = new Chauffør();
                    CurrentChauffør.Ch_ID = Int32.Parse(txtCHID.Text);   
                  
                    CurrentChauffør.ForNavn = txtFornavn.Text;
                    CurrentChauffør.EfterNavn = txtEfternavn.Text;
                    CurrentChauffør.OpretDato = dateTime_opret.Value;
                    int result = DataAccessChauffør.Insert(CurrentChauffør);
                    MessageBox.Show("Antal indsatte rækker er: " + result.ToString());

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        // Storage for IDENTITY values returned from database.        /// <summary>
        /// Verifies that the customer name text box is not empty.
        /// </summary>
        private bool IsCustomerNameValid()
        {
           
            if (txtCHID.Text == "")
            {
                MessageBox.Show("Indtast venligst valid ID.");
                return false;
            }
            else if (txtFornavn.Text == "")
            {
                MessageBox.Show("Indtast venligst ForNavn.");
                return false;
            }
            else if (txtEfternavn.Text == "")
            {
                MessageBox.Show("Indtast venligst EfterNavn.");
                return false;
            }

            else if (dateTime_opret.Checked == false)
            {
                MessageBox.Show("Indtast venligst valid dato!");
                return false;
            }

            else
            {
                return true;
            }
        }

        private void button_vise_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = DataAccessChauffør.Select();
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            txtCHID.Text = "";
            txtFornavn.Text = "";
            txtEfternavn.Text = "";
        }

        private void txtCHID_TextChanged(object sender, EventArgs e)
        {


           



        }

        private void button_slet_Click(object sender, EventArgs e)
        {
            if (IsCh_IDValid())
            {
                try
                {
                    int result = DataAccessChauffør.Delete(Int32.Parse(txtCHID.Text));
                    MessageBox.Show("Number of deleted rows is: " + result.ToString());
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fejl: " + ex.Message);
                }
            }

        }
        private bool IsCh_IDValid()
        {
            if (txtCHID.Text == "")
            {
                MessageBox.Show("Indtast venligst et Nummer.");
                return false;
            }
            else if ((Int32.Parse(txtCHID.Text) < 1))
            {
                MessageBox.Show("Indtast venligst en valid nummer.");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void button_rette_Click(object sender, EventArgs e)
        {
            if (IsChNummerValid())
            {
                try
                {
                  
                    int result=  DataAccessChauffør.Update(Int32.Parse(txtCHID.Text), txtFornavn.Text, txtEfternavn.Text,dateTime_opret.Value);
                    if (result > 0)
                    {                       
                        MessageBox.Show("Antal række påvirket:   " + result.ToString());
                      
                    }
                    else { MessageBox.Show("Kan ikke finde ID."); }


                }
                catch
                {
                    MessageBox.Show("Kan ikke redigere chauffør oplysninger.");
                }

            }

        }
        private bool IsChNummerValid()
        {

            if (txtCHID.Text == "")
            {
                MessageBox.Show("Indtast venligst et Kunde Nummer.");
                return false;
            }
            else if (Int32.Parse(txtCHID.Text) < 0)
            {
                MessageBox.Show("Indtast venligst en valid nummer.");
                return false;


            }
            else
            {
                return true;
            }

        }
    }
    }

    

