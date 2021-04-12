using Logbog.DataAccess;
using System;
using Logbog.Model;
using System.Windows.Forms;

namespace Kørselslogbog
{
    public partial class Form_bil : Form
    {
        private Bil Currentbil;
        public Form_bil()
        {
            InitializeComponent();
        }

        private bool IsbilNummerValid()
        {
            if (txtbilid.Text == "")
            {
                MessageBox.Show("Indtast venligst valid BIL ID.");
                return false;
            }
            else if ((Int32.Parse(txtbilid.Text) < 1))
            {
                MessageBox.Show("Indtast venligst valid BIL ID.");
                return false;
            }
            else
            {
                return true;
            }
        }
       

        private void button_Mainmenu_Click(object sender, EventArgs e)
        {
            Opret Menu = new Opret();
            this.Hide();
            Menu.Show();
        }

        private void button_vise_Click(object sender, EventArgs e)
        {
            if (IsbilNummerValid())
            {
                try
                {

                    dataGridView.DataSource = DataAccessBil.Select_biL(Int32.Parse(txtbilid.Text));
                }
                catch
                {
                    MessageBox.Show("BIl Oplysninger kan ikke vise!");
                }

            }
         }
        

        private void but_Gem_Click(object sender, EventArgs e)
        {
            try
            {
                if (IsbilNummerValid())
                {
                    Currentbil = new Bil();

                    Currentbil.Bil_ID = Int32.Parse(txtbilid.Text);
                    Currentbil.Nummerplade = txtNummerplade.Text;
                    Currentbil.bilfabrikat = txtbilfabrikat.Text;
                    Currentbil.model = textmodel.Text;
                    Currentbil.regdato = dateTime_registration.Value;
                    Currentbil.antalkm = decimal.Parse(txtkørtekm.Text);
                    
                    int result = DataAccessBil.InsertBil(Currentbil);
                    if (result > 0)
                    {
                        MessageBox.Show("Antal indsatte rækker er: " + result.ToString());

                      
                    }
                    else { MessageBox.Show("Invalid Bil ID / ID er allerede brugt i system"); }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fejl: " + ex.Message);
            }

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
           txtbilid .Text = "";
            txtNummerplade.Text = "";
           txtbilfabrikat.Text = "";
            textmodel.Text = "";
            txtkørtekm.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = DataAccessBil.Select();
        }

        private void button_slet_Click(object sender, EventArgs e)
        {
            if (IsbilNummerValid())
            {
                try
                {
                    int result = DataAccessBil.Deletebil(Int32.Parse(txtbilid.Text));
                    MessageBox.Show("Antal slettet rækker: " + result.ToString());               
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Fejl: " + ex.Message);
                }
            }

        }
       

    }
}




