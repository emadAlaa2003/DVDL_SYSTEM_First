using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static System.Net.Mime.MediaTypeNames;
namespace DVLDDataAccessLayer
{
    public  class clsDataTestAppointmont
    {
        public static bool FindTestAppointmentById(int TestAppointmentID, ref int TestTypeID,ref int LocalDrivingLicenseApplicationID, ref DateTime AppointmentDate, ref decimal PaidFees, ref int CreatedByUserID,ref bool IsLocked)

        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string qure = "SELECT * FROM TestAppointments where TestAppointmentID=@TestAppointmentID";
            SqlCommand command = new SqlCommand(qure, connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    TestTypeID = (int)reader["TestTypeID"];
                    LocalDrivingLicenseApplicationID = (int)reader["LocalDrivingLicenseApplicationID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    IsLocked=(bool)reader["IsLocked"];
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }
        public static int AddTestAppointment(int TestTypeID,  int LocalDrivingLicenseApplicationID,  DateTime AppointmentDate,  decimal PaidFees,  int CreatedByUserID,  bool IsLocked)
        {
            int AppointmentID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "INSERT INTO TestAppointments(TestTypeID, LocalDrivingLicenseApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked) " +
                "VALUES(@TestTypeID, @LocalDrivingLicenseApplicationID, @AppointmentDate, @PaidFees, @CreatedByUserID, @IsLocked); " +
                "SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    AppointmentID = insertedID;
                }
            }
            catch (Exception ex) { 
//Console.WriteLine(ex.ToString());
            }
            finally
            {
                connection.Close();
            }
            return AppointmentID;
        }
        public static bool UpdateTestAppointment(int TestAppointmentID,  int TestTypeID,  int LocalDrivingLicenseApplicationID,  DateTime AppointmentDate,  decimal PaidFees,  int CreatedByUserID,  bool IsLocked)
        {
            int rowsAffected = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "UPDATE TestAppointments SET TestTypeID=@TestTypeID, LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID, AppointmentDate=@AppointmentDate, " +
                "PaidFees=@PaidFees, CreatedByUserID=@CreatedByUserID, IsLocked=@IsLocked " +
                "WHERE TestAppointmentID=@TestAppointmentID";
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);
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
        public static DataTable GetAppointments() { 
            DataTable dt = new DataTable();
            
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT TestAppointmentID ,AppointmentDate,PaidFees,IsLocked FROM TestAppointments";
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
        public static DataTable GetAppointmentsByLocalAppID(int LocalDrivingLicenseApplicationID,int TestTypeID)
        {
            DataTable dt = new DataTable();
           
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT TestAppointmentID ,AppointmentDate,PaidFees,IsLocked FROM TestAppointments where LocalDrivingLicenseApplicationID=@LocalDrivingLicenseApplicationID and TestAppointments.TestTypeID=@TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
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
        public static bool IsThereActiveAppointment(int LocalDrivingLicenseApplicationID ,int TestTypeID)
        {
            int count = 0;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
             string query = @"SELECT count(*) 
                     FROM TestAppointments 
                     WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID 
                     AND TestTypeID = @TestTypeID 
                     AND IsLocked = 0";
            SqlCommand comand = new SqlCommand(query, connection);
            comand.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            comand.Parameters.AddWithValue("@TestTypeID", TestTypeID);
        
            try
            {
                connection.Open();
                object result = comand.ExecuteScalar();
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
            return (count>0);
        }
    }
}
