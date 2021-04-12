using System;
using System.Data.SqlClient;
using System.Data;
using Logbog.Model;



namespace Logbog.DataAccess
{
    public class DataAccessChauffør
    {
        // You need to exchange the part of the Source that says DESKTOP-ARSV9V5\MYDB to the name of your database server
        const string connectionString = @"Data Source=WIN-3755O2PKQ95;Initial Catalog=KØRSELSLOGBOG;Integrated Security=True";

        //****************************************************************select***********************************************************************************************//
        public static DataTable Select()
        {

            DataTable dataTable = new DataTable();
            SqlConnection cnn = new SqlConnection(connectionString);
            string sql, Output = "";
            sql = "Select * from Chauffører";
            SqlCommand command = new SqlCommand(sql, cnn);

            try
            {
                cnn.Open();

                // Run the query by calling ExecuteReader().
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    // Create a data table to hold the retrieved data.


                    // Load the data from SqlDataReader into the data table.
                    dataTable.Load(dataReader);

                    // Display the data from the data table in the data grid view.
                    //this.dgvCustomerOrders.DataSource = dataTable;

                    // Close the SqlDataReader.
                    dataReader.Close();


                }
            }
            catch
            {
                throw new Exception("Chauffører oplysninger kunne ikke indlæses i formularen.");
            }
            finally
            {
                // Close the connection.
                cnn.Close();
            }
            return dataTable;
        }

        //*************************************************************************view en chauffør**************************************************************************************//
        public static void CheckCh_ID(int Ch_ID)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open();
            SqlCommand sqlcmd = new SqlCommand();
            SqlCommand cmd = cnn.CreateCommand();
            cmd.CommandType = CommandType.Text;


            cmd.CommandText = "Select * from Chauffører";

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            //dataGridView1.DataSource = dt;

            if (dt.Rows.Count == 0)
            {
                //MessageBox.Show("Invalid ID");
                //txtCHID.Text = "";
                throw new Exception("Fejl: ");

            }
            else
            {

            }

            cnn.Close();


        }
        //***************************************************************************************************************************************************************//
        public static int Insert(Chauffør chauffør)
        {

            SqlConnection cnn = new SqlConnection(connectionString);
            string sql = "Insert into Chauffører(Ch_ID,ForNavn,EfterNavn,Opretdato) values (@Ch_ID,@ForNavn,@EfterNavn,@Opretdato)";
            SqlCommand command = new SqlCommand(sql, cnn);

            command.Parameters.AddWithValue("@ch_ID", chauffør.Ch_ID);
            command.Parameters.AddWithValue("@ForNavn", chauffør.ForNavn);
            command.Parameters.AddWithValue("@EfterNavn", chauffør.EfterNavn);
            command.Parameters.AddWithValue("@Opretdato", chauffør.OpretDato);

            int result = 0;
            try
            {
                cnn.Open();
                result = command.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                throw new Exception("Fejl: " + e.Message);
            }
            finally
            {
                command.Dispose();
                cnn.Close();
            }
            return result;
        }

        //*************************************************************************check id*************************************************************************************//
        public static SqlCommand CheckID(int chid)
        {

            DataTable dataTable = new DataTable();
            SqlConnection cnn = new SqlConnection(connectionString);
            string sql;
            sql = "Select * from Chauffører ch where ch.Ch_ID =@chID";
            SqlCommand command = new SqlCommand(sql, cnn);
            return command;
        }




        //***************************************************************************************************************************************************************//

        public static int Update(int ch_ID,string nyfornavn,string nyefternavn, DateTime oprettime)
        {

            SqlConnection cnn = new SqlConnection(connectionString);
            cnn.Open ();
           string sql= "Update Chauffører set ForNavn = @nyfornavn, EfterNavn = @nyefternavn, Opretdato = @oprettime where Ch_ID=@ch_ID";
            SqlCommand command = new SqlCommand(sql, cnn);
            //SqlDataAdapter adapter = new SqlDataAdapter();
            command.Parameters.AddWithValue("@Ch_ID", ch_ID);
            command.Parameters.AddWithValue("@nyfornavn", nyfornavn);
            command.Parameters.AddWithValue("@nyefternavn", nyefternavn);
            command.Parameters.AddWithValue("@oprettime", oprettime);


            //adapter.UpdateCommand = new SqlCommand(sql, cnn);
            int result = 0;
            try
            {
                //cnn.Open();
                result = command.ExecuteNonQuery();
                
            }
            catch (Exception e)
            {
                throw new Exception("Fejl: " + e.Message);
            }
            finally
            {
                command.Dispose();
                cnn.Close();
            }
            return result;


        }
        //*******************************************************************SLET********************************************************************************************//

        public static int Delete(int chid)
            {
            SqlConnection cnn = new SqlConnection(connectionString);
            string sql = "Delete from Chauffører where Chauffører.Ch_ID=@Ch_ID ";
            SqlCommand command = new SqlCommand(sql, cnn);
            command.Parameters.AddWithValue("@Ch_ID", chid);
           
            int result = 0;
            try
            {
                cnn.Open();
                result = command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                throw new Exception("Fejl: " + e.Message);
            }
            finally
            {
                command.Dispose();
                cnn.Close();
            }
            return result;
        }


    }
}
