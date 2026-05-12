using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer
{
    public class clsDataTestType
    {
       public static bool FindTestTypeById(int testID,ref string TestTitel,ref string TestDescription,ref decimal Fees)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string qure= "SELECT * FROM TestTypes where TestTypeID=@TestTypeID";
            SqlCommand command = new SqlCommand(qure, connection);
            command.Parameters.AddWithValue("@TestTypeID", testID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    TestTitel = (string)reader["TestTypeTitle"];
                    TestDescription = (string)reader["TestTypeDescription"];
                    Fees = (decimal)reader["TestTypeFees"];
                }

            }
            catch (Exception ex) { 
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }
       public static bool UpdateTestType(int testID, string TestTitel, string TestDescription, decimal Fees)
        {
            int rowsAffected = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string qure = "Update  TestTypes  set TestTypeTitle=@TestTypeTitle,TestTypeDescription=@TestTypeDescription,TestTypeFees=@TestTypeFees where TestTypeID=@TestTypeID";
            SqlCommand command = new SqlCommand(qure, connection);
            command.Parameters.AddWithValue("@TestTypeID", testID);
            command.Parameters.AddWithValue("@TestTypeTitle", TestTitel);
            command.Parameters.AddWithValue("@TestTypeDescription", TestDescription);
            command.Parameters.AddWithValue("@TestTypeFees", Fees);
            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return rowsAffected > 0;
        }
       public static DataTable GetAllTestTypes()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string qure = "SELECT * FROM TestTypes ";
            SqlCommand command = new SqlCommand(qure, connection);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                 dt.Load(reader);
                }

            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
    }
}
