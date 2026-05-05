using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DVLDBusinessLayer;
namespace DVLDConsolApp_PresentationLayer
{
    internal class Program
    {
        static void TestFindById(int PresonID)
        {
            clsPerson person = clsPerson.FindByID(PresonID);
            if (person == null)
            {
                Console.WriteLine("Person not fond");
            }
            else
            {
                Console.WriteLine("Person  fond");
            }
        }

        static void AddNewPerson()
        {
            clsPerson Person = new clsPerson();
            Person.NationalNo = "N6";
            Person.FirstName = "Emad";
            Person.SecondName = "Mohamed";
            Person.LastName = "Abd Elaziz";
            Person.DateOfBirth = new DateTime(1990, 1, 1);
            Person.Gendor = 1;
            Person.Address = "Amaan";
            Person.Phone = "01000000000";
            Person.NationalityCountryID = 1;

            if (Person.Save())
            {

                Console.WriteLine("Person Added Successfully with id=" + Person.PersonID);
            }

        }
        static void TestUpdatePerson(int PresonID)
        {
            clsPerson Person = clsPerson.FindByID(PresonID);
            Person.NationalNo = "N18";
            Person.FirstName = "Emad";
            Person.SecondName = "Ali";
            Person.LastName = "Abd Elaziz";
            Person.DateOfBirth = new DateTime(1990, 1, 1);
            Person.Gendor = 1;
            Person.Address = "Amaan";
            Person.Phone = "01000000000";
            Person.NationalityCountryID = 1;

            if (Person.Save())
            {

                Console.WriteLine("Person Update Successfull" );
            }

        }
        static void TestDeletePerson(int PresonID)
        {
       
            if (clsPerson.DeletePerson(PresonID))
            {
                Console.WriteLine("Person Deleted Successfull");
            }
        }
        static void TestGetAllPeople()
        {
            DataTable People = clsPerson.GetAllPeople();
            foreach (DataRow row in People.Rows)
            {
                Console.WriteLine(row["PersonID"].ToString() + " - " + row["FirstName"].ToString() + " - " + row["SecondName"].ToString());
            }
        }
        static void TestIsPersonExist(int PresonID)
        {
            if (clsPerson.IsPersonExist(PresonID))
            {
                Console.WriteLine("Person Exist");
            }
            else
            {
                Console.WriteLine("Person Not Exist");
            }
        }
        static void TestIsPersonExist(string PresonID)
        {
            if (clsPerson.IsPersonExist(PresonID))
            {
                Console.WriteLine("Person Exist");
            }
            else
            {
                Console.WriteLine("Person Not Exist");
            }
        }
        static void testFindCountryByID(int ID)

        {
            clsCountry Country1 = clsCountry.Find(ID);

            if (Country1 != null)
            {
                Console.WriteLine("Name: " + Country1.CountryName);

            }

            else
            {
                Console.WriteLine("Country [" + ID + "] Not found!");
            }
        }
        static void testAddNewCountry()


        {
            clsCountry Country1 = new clsCountry();

            Country1.CountryName = "palestine";
      


            if (Country1.Save())
            {

                Console.WriteLine("Country Added Successfully with id=" + Country1.ID);
            }

        }
        static void testFindCountryByName(string CountryName)

        {
            clsCountry Country1 = clsCountry.Find(CountryName);

            if (Country1 != null)
            {
                Console.WriteLine("Country [" + CountryName + "] isFound with ID = " + Country1.ID);
                Console.WriteLine("Name: " + Country1.CountryName);
   
            }

            else
            {
                Console.WriteLine("Country [" + CountryName + "] Is Not found!");
            }
        }

        static void testUpdateCountry(int ID)

        {
            clsCountry Country1 = clsCountry.Find(ID);

            if (Country1 != null)
            {
                //update whatever info you want
                Country1.CountryName = "palestin";



                if (Country1.Save())
                {

                    Console.WriteLine("Country updated Successfully ");
                }

            }
            else
            {
                Console.WriteLine("Country is you want to update is Not found!");
            }
        }
        static void ListCountries()
        {

            DataTable dataTable = clsCountry.GetAllCountries();

            Console.WriteLine("Coutries Data:");

            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine($"{row["CountryID"]},  {row["CountryName"]} ");
            }

        }
        static void testDeleteCountry(int ID)

        {

            if (clsCountry.isCountryExist(ID))

                if (clsCountry.DeleteCountry(ID))

                    Console.WriteLine("Country Deleted Successfully.");
                else
                    Console.WriteLine("Faild to delete Country.");

            else
                Console.WriteLine("Faild to delete: The Country with id = " + ID + " is not found");

        }
        static void testIsCountryExistByID(int ID)

        {

            if (clsCountry.isCountryExist(ID))

                Console.WriteLine("Yes, Country is there.");

            else
                Console.WriteLine("No, Country Is not there.");

        }
        static void testIsCountryExistByID(string ID)

        {

            if (clsCountry.isCountryExist(ID))

                Console.WriteLine("Yes, Country is there.");

            else
                Console.WriteLine("No, Country Is not there.");

        }

        static void testIsCountryExistByName(string CountryName)

        {

            if (clsCountry.isCountryExist(CountryName))

                Console.WriteLine("Yes, Country is there.");

            else
                Console.WriteLine("No, Country Is not there.");

        }

        static void TestFindUserById(int id)
        {
            clsUser user = clsUser.FindUserById(id);
            if (user != null)
            {
                Console.WriteLine("User Found: " + user.UserName + " personid: "+user.PersonId+" password :"+user.UserPassword+" IsActiv :"+user.IsActive);
            }
            else
            {
                Console.WriteLine("User Not Found");
            }
        }

        static void TestAddNewUser()
        {
            clsUser User = new clsUser();
            User.PersonId = 1027;
            User.UserName= "Test";
            User.UserPassword= "123";
            User.IsActive = true;

            if (User.Save())
            {

                Console.WriteLine("Person Added Successfully with id=" + User.UserId);
            }
        }

        static void TestDeleteUeser(int PresonID)
        {

            if (clsUser.DeletUser(PresonID))
            {
                Console.WriteLine("Person Deleted Successfull");
            }
        }
        static void TestListUsers()
        {

            DataTable dataTable = clsUser.GetAllUsers();

            Console.WriteLine("Users Data:");

            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine(row["UserID"].ToString() + " - " + row["PersonID"].ToString() + " - " + row["FullName"].ToString() + " - " + row["UserName"].ToString() + " - " + row["Password"].ToString() + " - " + row["IsActive"].ToString());
            }

        }
        static void TestUpdateUser(int UserId)
        {
            clsUser User = clsUser.FindUserById(UserId);

            User.UserName = "Test";
            User.UserPassword = "123";
            User.IsActive = true;


            if (User.Save())
            {

                Console.WriteLine("User Update Successfull");
            }
        }

        static void testIsUserExistByID(int ID)

        {

            if (clsUser.IsUseExists(ID))

                Console.WriteLine("Yes, Country is there.");

            else
                Console.WriteLine("No, Country Is not there.");

        }
        static void Main(string[] args)
        {
            //TestFindById(1);
            //AddNewPerson();
            //TestUpdatePerson(1026);
            //TestGetAllPeople();
            //TestDeletePerson(1026);
            //TestIsPersonExist(1);
            //testFindCountryByID(10);
            //testFindCountryByName("palestin");
            //testAddNewCountry();
            //testUpdateCountry(194);
            //ListCountries();
            //testFindCountryByID(194);
            //testDeleteCountry(194);
            //testIsCountryExistByID("1");
            //testIsCountryExistByName("palestine");
            //TestIsPersonExist("n1");
            //TestFindUserById(1);
            //TestAddNewUser();
            //TestUpdateUser(21);
            //TestListUsers();
            //TestDeleteUeser(1);
            testIsUserExistByID(1);
           Console.ReadKey();
        }
    }
}
