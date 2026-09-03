using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace DVLDDataAccessLayer
{
    public  class ClsDataTest
    {
        public static bool FindTest(int TestID,ref int TestAppointmentID,ref bool TestResult,ref string Notes ,ref int CreatedByUserID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string qure = "SELECT * FROM Tests where TestID=@TestID";
            SqlCommand command = new SqlCommand(qure, connection);
            command.Parameters.AddWithValue("@TestID", TestID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    if(reader["Notes"] != DBNull.Value)
                    {
                        Notes = (string)reader["Notes"];
                    }
                    else
                    {  
                        Notes ="";
                    }
                  

                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    TestResult = (bool)reader["TestResult"];
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }
        public static int AddTest(int TestAppointmentID,  bool TestResult,  string Notes,  int CreatedByUserID)
        {
            int AppointmentID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "INSERT INTO Tests(TestAppointmentID, TestResult, Notes, CreatedByUserID) " +
                "VALUES(@TestAppointmentID, @TestResult, @Notes, @CreatedByUserID); " +
                "SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    AppointmentID = insertedID;
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return AppointmentID;
        }
        public static bool UpdateTest(int TestID, int TestAppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            int rowsAffected = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "UPDATE Tests SET TestAppointmentID=@TestAppointmentID, TestResult=@TestResult, Notes=@Notes, " +
                " CreatedByUserID=@CreatedByUserID " +
                "WHERE TestID=@TestID";
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestID", TestID);
            command.Parameters.AddWithValue("@TestResult", TestResult);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                Connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Message: " + ex.Message);
            }
            finally
            {
                Connection.Close();

            }

            return (rowsAffected > 0);
        }
        public static bool DeletTest(int TestID)
        {
            int rowsAffected = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = @"Delete Tests 
                                where TestID = @TestID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestID", TestID);
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
            return (rowsAffected > 0);
        }
        public static int GetTestTrilCount(int LocalDrivingLicenseApplicationID, int TestTypeID, bool TestResult)
        {
            int count = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT count(*) FROM  TestAppointments INNER JOIN  Tests ON TestAppointments.TestAppointmentID = Tests.TestAppointmentID " +
                " Where TestAppointments.LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID and TestAppointments.TestTypeID= @TestTypeID and  Tests.TestResult=@TestResult";
            SqlCommand comand=new SqlCommand(query, connection);
            comand.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            comand.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            comand.Parameters.AddWithValue("@TestResult", TestResult);
            try
            {
                connection.Open();
                object result = comand.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int parsedCount))
                {
                    count = parsedCount;
                }
            }
            catch (Exception ex) {
            }
            finally
            {
                connection.Close();
            }
            return count;

        }
    }
}
