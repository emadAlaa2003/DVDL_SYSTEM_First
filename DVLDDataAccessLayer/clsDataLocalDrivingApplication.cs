using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;
using static System.Net.Mime.MediaTypeNames;

namespace DVLDDataAccessLayer
{
    public class clsDataLocalDrivingApplication
    {
        public static bool FindLocalDrivingApplication(int LocalDrivingLicenseApplicationID, ref int ApplicationID, ref int LicenseClassID)
        {
            bool IsFound = false;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string qure = "SELECT * FROM LocalDrivingLicenseApplications where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(qure, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
                }

            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }
        public static bool FindApplicationID(ref int LocalDrivingLicenseApplicationID, int ApplicationID, ref int LicenseClassID)
        {
            bool IsFound = false;


            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string qure = "SELECT * FROM LocalDrivingLicenseApplications where ApplicationID=@ApplicationID";
            SqlCommand command = new SqlCommand(qure, connection);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    LicenseClassID = (int)reader["LicenseClassID"];
                }

            }
            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }
        public static int AddLocalDrivingLicenseApplication(int LicenseClassID, int ApplicationID)
        {
            int LocalDrivingLicenseApplicationID = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "INSERT INTO LocalDrivingLicenseApplications(LicenseClassID, ApplicationID) VALUES(@LicenseClassID, @ApplicationID); SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            try
            {
                Connection.Open();
                object resalt = command.ExecuteScalar();
                if (resalt != null && int.TryParse(resalt.ToString(), out int insertedId))
                {
                    LocalDrivingLicenseApplicationID = insertedId;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Details: " + ex.Message);
            }
            finally
            {
                Connection.Close();
            }
            return LocalDrivingLicenseApplicationID;
        }

        public static bool updateLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID, int ApplicationID, int LicenseClassID)
        {
            int rowsAffected = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "UPDATE LocalDrivingLicenseApplications SET ApplicationID=@ApplicationID, LicenseClassID=@LicenseClassID WHERE LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            try
            {

                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Details: " + ex.Message);
            }
            finally { connection.Close(); }
            return rowsAffected > 0;
        }
        public static bool DeleteeLocalDrivingLicenseApplication(int LocalDrivingLicenseApplicationID)
        {
            int rowsAffected = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "DELETE FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID";
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            try
            {
                Connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Message: " + ex.Message);
                //rowsAffected = -1;
            }
            finally
            {
                Connection.Close();
            }
            return rowsAffected > 0;
        }
        public static DataTable GetAllLocalDrivingLicenseApplications()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM LocalDrivingLicenseApplications_View";
            SqlCommand command = new SqlCommand(query, connection);
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
                // Console.WriteLine("Error Message: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;
        }
        public static int GetCountPassedTest(int LocalDrivingLicenseApplicationID)
        {
            int count = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "select count(*) from dbo.TestAppointments INNER JOIN dbo.Tests  on  dbo.TestAppointments.TestAppointmentID = dbo.Tests.TestAppointmentID  where dbo.TestAppointments.LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID  AND dbo.Tests.TestResult = 1; ";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int parsedCount))
                {
                    count = parsedCount;
                }
            }
            catch (Exception ex)
            {
            }
            finally
            {
                connection.Close();
            }
            return count;
        }
        public static bool IsThereAnActiveApplicationForThisClass(int PersonID, int LicenseClassID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);

            string query = @"
        SELECT TOP 1 Found = 1 
        FROM LocalDrivingLicenseApplications 
        INNER JOIN Applications 
            ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
        WHERE Applications.ApplicantPersonID = @PersonID 
          AND LocalDrivingLicenseApplications.LicenseClassID = @LicenseClassID
          AND Applications.ApplicationStatus IN (1, 3)";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    isFound = true;
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
    }
}
