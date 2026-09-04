using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Net;
using System.Data;
using System.CodeDom;

namespace DVLDDataAccessLayer
{
    public class clsDataApplications
    {

        public static bool FindApplicationByID(int applicationId, ref int ApplicantPersonID, ref DateTime ApplicationDate, ref int ApplicationTypeID
                                , ref byte ApplicationStatus, ref DateTime LastStatusDate, ref decimal PaidFees, ref int CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string qure = "SELECT * FROM Applications where ApplicationID=@ApplicationID";
            SqlCommand command = new SqlCommand(qure, connection);
            command.Parameters.AddWithValue("@ApplicationID", applicationId);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    ApplicantPersonID = (int)reader["ApplicantPersonID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationStatus = (byte)reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
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
        public static bool FindApplicationByPersonID(ref int ApplicationID, int ApplicantPersonID, ref DateTime ApplicationDate, ref int ApplicationTypeID
                                , ref byte ApplicationStatus, ref DateTime LastStatusDate, ref decimal PaidFees, ref int CreatedByUserID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string qure = "SELECT * FROM Applications where ApplicantPersonID=@ApplicantPersonID";
            SqlCommand command = new SqlCommand(qure, connection);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    IsFound = true;
                    ApplicationID = (int)reader["ApplicationID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    ApplicationTypeID = (int)reader["ApplicationTypeID"];
                    ApplicationStatus = (byte)reader["ApplicationStatus"];
                    LastStatusDate = (DateTime)reader["LastStatusDate"];
                    PaidFees = (decimal)reader["PaidFees"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
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
        public static int AddApplication(int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID
                                , byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            int ApplicationID = -1;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "INSERT INTO Applications(ApplicantPersonID, ApplicationDate, ApplicationTypeID, ApplicationStatus, LastStatusDate, PaidFees, CreatedByUserID) " +
                "VALUES(@ApplicantPersonID, @ApplicationDate, @ApplicationTypeID, @ApplicationStatus, @LastStatusDate, @PaidFees, @CreatedByUserID); " +
                "SELECT SCOPE_IDENTITY();";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    ApplicationID = insertedID;
                }
            }
            catch (Exception ex) {
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return ApplicationID;
        }
        public static bool UpdateApplication(int applicationId, int ApplicantPersonID, DateTime ApplicationDate, int ApplicationTypeID
                                , byte ApplicationStatus, DateTime LastStatusDate, decimal PaidFees, int CreatedByUserID)
        {
            int rowsAffected = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "UPDATE Applications SET ApplicantPersonID=@ApplicantPersonID, ApplicationDate=@ApplicationDate, ApplicationTypeID=@ApplicationTypeID, " +
                "ApplicationStatus=@ApplicationStatus, LastStatusDate=@LastStatusDate, PaidFees=@PaidFees, CreatedByUserID=@CreatedByUserID " +
                "WHERE ApplicationID=@ApplicationID";
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@ApplicationID", applicationId);
            command.Parameters.AddWithValue("@ApplicantPersonID", ApplicantPersonID);
            command.Parameters.AddWithValue("@ApplicationDate", ApplicationDate);
            command.Parameters.AddWithValue("@ApplicationTypeID", ApplicationTypeID);
            command.Parameters.AddWithValue("@ApplicationStatus", ApplicationStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            try
            {
                Connection.Open();
                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error Message: " + ex.Message);
                rowsAffected = -1;
            }
            finally
            {
                Connection.Close();

            }
            return rowsAffected > 0;
        }

        public static bool DeletApplication(int applicationId)
        {
            int rowsAffected = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "DELETE FROM Applications WHERE ApplicationID=@ApplicationID";
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@ApplicationID", applicationId);
            try
            {
                Connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //  Console.WriteLine("Error Message: " + ex.Message);
                rowsAffected = -1;
            }
            finally
            {
                Connection.Close();
            }
            return rowsAffected > 0;


        }
        public static DataTable GetAllApplications()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT * FROM Applications";
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
    

    public static bool ChangeStatues(int applicationId, byte newStatus, DateTime LastStatusDate)
        {
            int rowsAffected = -1;
            SqlConnection Connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "UPDATE Applications SET ApplicationStatus=@ApplicationStatus, LastStatusDate=@LastStatusDate WHERE ApplicationID=@ApplicationID";
            SqlCommand command = new SqlCommand(query, Connection);
            command.Parameters.AddWithValue("@ApplicationID", applicationId);
            command.Parameters.AddWithValue("@ApplicationStatus", newStatus);
            command.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            try
            {
                Connection.Open();
                rowsAffected = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Console.WriteLine("Error Message: " + ex.Message);
                rowsAffected = -1;
            }
            finally
            {
                Connection.Close();
            }
            return rowsAffected > 0;
        }
    }
    }
