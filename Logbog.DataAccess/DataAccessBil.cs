using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Logbog.Model;

namespace Logbog.DataAccess
{
      public class DataAccessBil
        {
            const string connectionString = @"Data Source=WIN-3755O2PKQ95;Initial Catalog=KØRSELSLOGBOG;Integrated Security=True";

        //*****************************************************Select****************************************************************************************************
        public static DataTable Select()
        {

            DataTable dataTable = new DataTable();
            SqlConnection cnn = new SqlConnection(connectionString);
            string sql;
            sql = "Select * from Bil";
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
                throw new Exception("Bil oplysninger kunne ikke findes.");
            }
            finally
            {
                // Close the connection.
                cnn.Close();
            }
            return dataTable;
        }
        //*****************************************************Søg****************************************************************************************************
        public static List<Bil> Select_biL(int bilnummer)
            {

                // DataTable dataTable = new DataTable();
                List<Bil> bilList = new List<Bil>();
                SqlConnection cnn = new SqlConnection(connectionString);
                string sql;
                sql = "Select * from Bil where Bil_ID =@bilnummer";
                SqlCommand command = new SqlCommand(sql, cnn);
                command.Parameters.AddWithValue("@bilnummer", bilnummer);



                try
                {
                    cnn.Open();

                    // Run the query by calling ExecuteReader().
                    using (SqlDataReader dataReader = command.ExecuteReader())
                    {
                        // Create a data table to hold the retrieved data.

                        while (dataReader.Read())
                        {
                            Bil bil = new Bil();

                            bil.Bil_ID = int.Parse(dataReader.GetValue(0).ToString());
                            bil.Nummerplade = dataReader.GetValue(1).ToString();
                            bil.bilfabrikat= dataReader.GetValue(2).ToString();
                            bil.model = dataReader.GetValue(3).ToString();                            
                            bil.regdato= DateTime.Parse(dataReader.GetValue(4).ToString());
                            bil.antalkm  = decimal.Parse(dataReader.GetValue(5).ToString());                 
                                                    
                           bilList.Add(bil);
                        }
                        // Load the data from SqlDataReader into the data table.
                        //dataTable.Load(dataReader);

                        // Display the data from the data table in the data grid view.
                        //this.dgvCustomerOrders.DataSource = dataTable;

                        // Close the SqlDataReader.
                        dataReader.Close();


                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Bil Oplysninger kan ikke findes.");
                }
                finally
                {
                    // Close the connection.
                    cnn.Close();
                }
                return bilList;
            }


        //*****************************************************INSERT****************************************************************************************************

        public static int InsertBil(Bil bil)
        {

            SqlConnection cnn = new SqlConnection(connectionString);
            int result = 0;
            if (IsbilNummerAvailable(bil.Bil_ID) == false)
            {
                string sql = "Insert into Bil (Bil_ID,Nummerplade,Bilfabrikat,Model,Reg_Dato,Antalkm) values (@Bil_ID,@Nummerplade," +
                "@bilfabrikat,@model,@regdato,@antalkm)";
                SqlCommand command = new SqlCommand(sql, cnn);
                command.Parameters.AddWithValue("@Bil_ID", bil.Bil_ID);
                command.Parameters.AddWithValue("@Nummerplade",bil.Nummerplade);
                command.Parameters.AddWithValue("@bilfabrikat", bil.bilfabrikat);
                command.Parameters.AddWithValue("@model", bil.model);
                command.Parameters.AddWithValue("@regdato", bil.regdato);
                command.Parameters.AddWithValue("@antalkm", bil.antalkm);

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
                   
                }

            }

            return result;
        }
        public static bool IsbilNummerAvailable(int bilid)
        {
            bool flag = false;

            SqlConnection cnn = new SqlConnection(connectionString);
            string sql = "SELECT Bil_ID FROM Bil WHERE Bil_ID = @bilid";
            SqlCommand command = new SqlCommand(sql, cnn);
            SqlParameter bilnr = new SqlParameter("@bilid", SqlDbType.VarChar);

          bilnr.Value = bilid;


            command.Parameters.Add(bilnr);

            try
            {

                cnn.Open();
                using (SqlDataReader dataReader = command.ExecuteReader())
                {

                    // dataReader.Read();
                    while (dataReader.Read())
                    {

                        bilid = Int32.Parse(dataReader.GetValue(0).ToString());

                        flag = true;


                    }
                    dataReader.Close();

                }
            }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                command.Dispose();
                cnn.Close();
            }


            return flag;

        }

        //*****************************************************INSERT****************************************************************************************************


        //    public static DataTable SelectSaldoInfo(int kontoNummer)
        //    {

        //        DataTable dataTable = new DataTable();
        //        SqlConnection cnn = new SqlConnection(connectionString);
        //        string sql, Output = "";
        //        if (IsKontoNummerAvailable(kontoNummer) == true)
        //        {
        //            sql = "Select ko.kontoNummer, ko.saldo, ko.kundeNummer from Konto ko where ko.kontoNummer =@kontoNummer";
        //            SqlCommand command = new SqlCommand(sql, cnn);
        //            command.Parameters.AddWithValue("@kontoNummer", kontoNummer);



        //            try
        //            {
        //                cnn.Open();

        //                // Run the query by calling ExecuteReader().
        //                using (SqlDataReader dataReader = command.ExecuteReader())
        //                {
        //                    // Create a data table to hold the retrieved data.


        //                    // Load the data from SqlDataReader into the data table.
        //                    dataTable.Load(dataReader);

        //                    // Display the data from the data table in the data grid view.
        //                    //this.dgvCustomerOrders.DataSource = dataTable;

        //                    // Close the SqlDataReader.
        //                    dataReader.Close();


        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                throw new Exception("kunde konto information kunne ikke indlæses i formularen.");
        //            }
        //            finally
        //            {
        //                // Close the connection.
        //                cnn.Close();
        //            }
        //        }

        //        return dataTable;
        //    }
        //    public static bool IsKontoNummerAvailable(int kontoNummer)
        //    {
        //        bool flag = false;

        //        SqlConnection cnn = new SqlConnection(connectionString);
        //        string sql = "SELECT kontoNummer FROM Konto WHERE kontoNummer = @kontoNummer";
        //        SqlCommand command = new SqlCommand(sql, cnn);
        //        SqlParameter kontonr = new SqlParameter("@kontoNummer", SqlDbType.VarChar);

        //        kontonr.Value = kontoNummer;


        //        command.Parameters.Add(kontonr);

        //        try
        //        {

        //            cnn.Open();
        //            using (SqlDataReader dataReader = command.ExecuteReader())
        //            {

        //                // dataReader.Read();
        //                while (dataReader.Read())
        //                {

        //                    kontoNummer = Int32.Parse(dataReader.GetValue(0).ToString());

        //                    flag = true;


        //                }
        //                dataReader.Close();

        //            }
        //        }

        //        catch (Exception ex)
        //        {
        //            throw new Exception(ex.Message);
        //        }
        //        finally
        //        {
        //            command.Dispose();
        //            cnn.Close();
        //        }


        //        return flag;

        //    }

        //*****************************************************delete****************************************************************************************************

        public static int Deletebil(int bilNummer)
        {
            SqlConnection cnn = new SqlConnection(connectionString);
            int result = 0;
            if (IsbilNummerAvailable(bilNummer) == true)
            {
                string sql = "Delete from Bil where Bil_ID=@bil_id";

                SqlCommand command = new SqlCommand(sql, cnn);
                command.Parameters.AddWithValue("@bil_id", bilNummer);
                
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
            }

            return result;
        }

        //*****************************************************Update****************************************************************************************************

        //    public static int UpdateInsatPenge(Transaction deposit)
        //    {

        //        SqlConnection cnn = new SqlConnection(connectionString);
        //        int result = 0;
        //        if (IsKontoNummerAvailable(deposit.KontoNummer) == true)
        //        {
        //            string sql = "Update Konto set saldo = saldo + @insatPenge where kontoNummer=@kontoNummer";
        //            SqlCommand command = new SqlCommand(sql, cnn);
        //            SqlParameter kntNr = new SqlParameter("@kontoNummer", SqlDbType.Int);
        //            SqlParameter instpenge = new SqlParameter("@insatPenge", SqlDbType.Decimal);
        //            kntNr.Value = deposit.KontoNummer;

        //            instpenge.Value = deposit.Amount;

        //            command.Parameters.Add(kntNr);
        //            command.Parameters.Add(instpenge);

        //            //SqlDataAdapter adapter = new SqlDataAdapter();


        //            //adapter.UpdateCommand = new SqlCommand(sql, cnn);

        //            try
        //            {
        //                cnn.Open();
        //                result = command.ExecuteNonQuery();
        //                //throw new Exception("Number of updated rows is: " + result.ToString());
        //            }
        //            catch (Exception e)
        //            {
        //                throw new Exception("Fejl: " + e.Message);
        //            }
        //            finally
        //            {
        //                command.Dispose();
        //                cnn.Close();
        //            }
        //        }
        //        return result;
        //    }
        //    public static decimal getSaldo(int kontoNummer)
        //    {

        //        DataTable dataTable = new DataTable();
        //        SqlConnection cnn = new SqlConnection(connectionString);
        //        string sql, Output = "";
        //        decimal saldo = 0;
        //        if (IsKontoNummerAvailable(kontoNummer) == true)
        //        {
        //            sql = "Select  ko.saldo from Konto ko where ko.kontoNummer =@kontoNummer";
        //            SqlCommand command = new SqlCommand(sql, cnn);
        //            command.Parameters.AddWithValue("@kontoNummer", kontoNummer);



        //            try
        //            {
        //                cnn.Open();

        //                // Run the query by calling ExecuteReader().
        //                using (SqlDataReader dataReader = command.ExecuteReader())
        //                {
        //                    // Create a data table to hold the retrieved data.


        //                    while (dataReader.Read())
        //                    {

        //                        saldo = decimal.Parse(dataReader.GetValue(0).ToString());

        //                        //flag = true;


        //                    }

        //                    // Close the SqlDataReader.
        //                    dataReader.Close();


        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                throw new Exception("kunde konto information kunne ikke indlæses i formularen.");
        //            }
        //            finally
        //            {
        //                // Close the connection.
        //                cnn.Close();
        //            }
        //        }

        //        return saldo;
        //    }
        //    public static int UpdateHaevePenge(Transaction withdraw)
        //    {

        //        SqlConnection cnn = new SqlConnection(connectionString);
        //        int result = 0;
        //        if (IsKontoNummerAvailable(withdraw.KontoNummer) == true)
        //        {
        //            string sql = "Update Konto set saldo = saldo - @haeveBelob where kontoNummer=@kontoNummer";
        //            SqlCommand command = new SqlCommand(sql, cnn);
        //            SqlParameter kntNr = new SqlParameter("@kontoNummer", SqlDbType.Int);
        //            SqlParameter haevepenge = new SqlParameter("@haeveBelob", SqlDbType.Decimal);
        //            kntNr.Value = withdraw.KontoNummer;
        //            haevepenge.Value = withdraw.Amount;

        //            command.Parameters.Add(kntNr);
        //            command.Parameters.Add(haevepenge);

        //            //SqlDataAdapter adapter = new SqlDataAdapter();


        //            //adapter.UpdateCommand = new SqlCommand(sql, cnn);

        //            try
        //            {
        //                cnn.Open();
        //                result = command.ExecuteNonQuery();
        //                //throw new Exception("Number of updated rows is: " + result.ToString());
        //            }
        //            catch (Exception e)
        //            {
        //                throw new Exception("Fejl: " + e.Message);
        //            }
        //            finally
        //            {
        //                command.Dispose();
        //                cnn.Close();
        //            }
        //        }
        //        return result;
        //    }

        //}


    }


}

