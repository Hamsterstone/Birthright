using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Birthright
{
    class Database
    {
        //Define fields
        SqlConnection connection = new SqlConnection();
        SqlCommand command = new SqlCommand();
        private SqlDataAdapter myDataAdapter = new SqlDataAdapter();

        //
        public Database()
        {

            string connectionString =
                @"Data Source=TREAD\SQLEXPRESS;Initial Catalog=Birthright;Integrated Security=True";
            connection.ConnectionString = connectionString;
            command.Connection = connection;
        }

        public DataTable FillDatatable(string table)
        {
            DataTable myDataTable = new DataTable();

            SqlCommand myCommand = connection.CreateCommand();
            myCommand.Connection = connection;
            myCommand.CommandText = "ShowAllFrom";
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Parameters.AddWithValue("@ViewName", table);
            using (myDataAdapter = new SqlDataAdapter(myCommand))
            {
                connection.Open();
                myDataAdapter.Fill(myDataTable);
                connection.Close();
            }
            return myDataTable;

        }
        //TODO Set up admin controls in database manager
        public void AdminTools(Dictionary<string, string> data, string action)
        {
            try
            {
                SqlCommand myCommand = connection.CreateCommand();
                myCommand.Connection = connection;
                switch (action)
                {
                    case "Add New Ruler":
                        myCommand.CommandText = "AdminAddRuler";
                        myCommand.Parameters.AddWithValue("@RulerNameIn", data["RulerName"]);
                        myCommand.Parameters.AddWithValue("@RulerAbbreviationIn", data["RulerAbbreviation"]);
                        break;
                    case "Update Ruler":
                        myCommand.CommandText = "AdminUpdateRuler";
                        myCommand.Parameters.AddWithValue("@RulerIDIn", data["RulerID"]);
                        myCommand.Parameters.AddWithValue("@RulerNameIn", data["RulerName"]);
                        myCommand.Parameters.AddWithValue("@RulerAbbreviationIn", data["RulerAbbreviation"]);
                       break;
                    case "Delete Ruler":
                        myCommand.CommandText = "AdminDelete";
                        myCommand.Parameters.AddWithValue("@TableNameIn", "Ruler");
                        myCommand.Parameters.AddWithValue("@ColumnNameIn", "RulerID");
                        myCommand.Parameters.AddWithValue("@IDNumber", data["RulerID"]);
                        break;
                    case "Add New Realm":
                        myCommand.CommandText = "AdminAddRealm";
                        myCommand.Parameters.AddWithValue("@RealmNameIn", data["RealmName"]);
                        myCommand.Parameters.AddWithValue("@RealmOwnerIDFKIn", data["RealmOwner"]);

                        break;
                    case "Update Realm":
                        myCommand.CommandText = "AdminUpdateRealm";
                        myCommand.Parameters.AddWithValue("@RealmIDIn", data["RealmID"]);
                        myCommand.Parameters.AddWithValue("@RealmNameIn", data["RealmName"]);
                        myCommand.Parameters.AddWithValue("@RealmOwnerIDFKIn", data["RealmOwner"]);

                        break;
                    case "Delete Realm":
                        myCommand.CommandText = "AdminDelete";
                        myCommand.Parameters.AddWithValue("@TableNameIn", "Realm");
                        myCommand.Parameters.AddWithValue("@ColumnNameIn", "RealmID");
                        myCommand.Parameters.AddWithValue("@IDNumber", data["RealmID"]);
                        break;
                    case "Add New Province":
                        myCommand.CommandText = "AdminAddProvince";
                        myCommand.Parameters.AddWithValue("@ProvinceNameIn", data["ProvinceName"]);
                        myCommand.Parameters.AddWithValue("@ProvinceSizeIn", data["ProvinceSize"]);//convert to int?
                        myCommand.Parameters.AddWithValue("@ProvinceTerrainIn", data["ProvinceTerrain"]);
                        myCommand.Parameters.AddWithValue("@ProvinceSecondaryTerrainIn", data["ProvinceSecondaryTerrain"]);
                        myCommand.Parameters.AddWithValue("@ProvinceRealmIDFKIn", data["ProvinceOwner"]);//may need converting to RealmFKID from ruler name/abbr string.
                        myCommand.Parameters.AddWithValue("@ProvinceLoyaltyIn", data["ProvinceLoyalty"]);
                        myCommand.Parameters.AddWithValue("@ProvinceRoadIn", data["ProvinceRoad"]);
                        break;
                    case "Update Province":
                        myCommand.CommandText = "AdminUpdateProvince";
                        myCommand.Parameters.AddWithValue("@ProvinceIDIn", data["ProvinceID"]);
                        myCommand.Parameters.AddWithValue("@ProvinceNameIn", data["ProvinceName"]);
                        myCommand.Parameters.AddWithValue("@ProvinceSizeIn", data["ProvinceSize"]);
                        myCommand.Parameters.AddWithValue("@ProvinceTerrainIn", data["ProvinceTerrain"]);
                        myCommand.Parameters.AddWithValue("@ProvinceSecondaryTerrainIn", data["ProvinceSecondaryTerrain"]);
                        myCommand.Parameters.AddWithValue("@ProvinceRealmIDFKIn", data["ProvinceOwner"]);
                        myCommand.Parameters.AddWithValue("@ProvinceLoyaltyIn", data["ProvinceLoyalty"]);
                        myCommand.Parameters.AddWithValue("@ProvinceRoadIn", data["ProvinceRoad"]);
                        break;
                    case "Delete Province":
                        myCommand.CommandText = "AdminDelete";
                        myCommand.Parameters.AddWithValue("@TableNameIn", "Province");
                        myCommand.Parameters.AddWithValue("@ColumnNameIn", "ProvinceID");
                        myCommand.Parameters.AddWithValue("@IDNumber", data["ProvinceID"]);
                        break;
                    case "Add New Holding":
                        myCommand.CommandText = "AdminAddHolding";
                        myCommand.Parameters.AddWithValue("@HoldingTypeIn", data["HoldingType"]);
                        myCommand.Parameters.AddWithValue("@HoldingSizeIn", data["HoldingSize"]);
                        myCommand.Parameters.AddWithValue("@HoldingRealmIDFKIn", data["HoldingOwner"]);
                        myCommand.Parameters.AddWithValue("@HoldingLocationIDFKIn", data["HoldingLocation"]);

                        break;
                    case "Update Holding":
                        myCommand.CommandText = "AdminUpdateHolding";
                        myCommand.Parameters.AddWithValue("@HoldingIDIn", data["HoldingID"]);
                        myCommand.Parameters.AddWithValue("@HoldingTypeIn", data["HoldingType"]);
                        myCommand.Parameters.AddWithValue("@HoldingSizeIn", data["HoldingSize"]);
                        myCommand.Parameters.AddWithValue("@HoldingRealmIDFKIn", data["HoldingOwner"]);
                        myCommand.Parameters.AddWithValue("@HoldingLocationIDFKIn", data["HoldingLocation"]);
                        break;
                    case "Delete Holding":
                        myCommand.CommandText = "AdminDelete";
                        myCommand.Parameters.AddWithValue("@TableNameIn", "Holding");
                        myCommand.Parameters.AddWithValue("@ColumnNameIn", "HoldingID");
                        myCommand.Parameters.AddWithValue("@IDNumber", data["HoldingID"]);
                        break;
                }







                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();
                myCommand.ExecuteNonQuery();
                connection.Close();


            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        internal void RefreshCombinedView()
        {


            SqlCommand myCommand = connection.CreateCommand();
            myCommand.Connection = connection;
            myCommand.CommandText = "BuildCombinedViewTable";
            myCommand.CommandType = CommandType.StoredProcedure;

            connection.Open();
            myCommand.ExecuteNonQuery();
            connection.Close();
        }

        public DataTable FillIDBiDictionaries(string biDictionaryName)
        {
            try
            {

                DataTable myDataTable = new DataTable();

                SqlCommand myCommand = connection.CreateCommand();
                myCommand.Connection = connection;

                if (biDictionaryName == "Abbr")
                {
                    myCommand.CommandText = "GetIDAndAbbr";
                    myCommand.Parameters.AddWithValue("@ViewName", "Ruler");
                }else if (biDictionaryName == "RealmIDVsRulerAbbr")
                {
                    myCommand.CommandText = "ShowAllFrom";
                    myCommand.Parameters.AddWithValue("@ViewName", "RealmIDVsRulerAbbr");
                    
                }
                else {
                    myCommand.CommandText = "GetIDAndName";
                    myCommand.Parameters.AddWithValue("@ViewName", biDictionaryName);
                }

                myCommand.CommandType = CommandType.StoredProcedure;

           using (myDataAdapter = new SqlDataAdapter(myCommand))
                {
                    connection.Open();
                    myDataAdapter.Fill(myDataTable);
                    connection.Close();
                }
                return myDataTable;

            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message);
                return null;
            }
}

        public DataTable SearchForItem(string table, string item)
        {
            DataTable myDataTable = new DataTable();

            SqlCommand myCommand = connection.CreateCommand();
            myCommand.Connection = connection;

            //if (table == "Movies")
            //{
                myCommand.CommandText = "FindFromProvince";
            //}
            //else if (table == "Customer")


            //{
            //    myCommand.CommandText = "FindFromCustomer";

            //}



            // myCommand.CommandText = "ShowAllFrom";
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Parameters.AddWithValue("@Find", item);
            using (myDataAdapter = new SqlDataAdapter(myCommand))
            {
                connection.Open();
                myDataAdapter.Fill(myDataTable);
                connection.Close();
            }
            return myDataTable;


            //string sqlQuery = null;
            //DataTable myDataTable = new DataTable();

            //switch (table)
            //{
            //    case "Movies":
            //        sqlQuery = @"SELECT * FROM " + table + " WHERE Title LIKE '%" + item + "%' ORDER by Title";
            //        //   DataTable myDataTable = new DataTable();
            //        using (myDataAdapter = new SqlDataAdapter(sqlQuery, connection))
            //        {
            //            connection.Open();
            //            myDataAdapter.Fill(myDataTable);
            //            connection.Close();
            //            return myDataTable;
            //        }
            //    case "Customer":
            //        sqlQuery = @"SELECT * FROM " + table + " WHERE LastName LIKE '" + item + "%' ORDER by LastName";
            //        //  DataTable myDataTable = new DataTable();
            //        using (myDataAdapter = new SqlDataAdapter(sqlQuery, connection))
            //        {
            //            connection.Open();
            //            myDataAdapter.Fill(myDataTable);
            //            connection.Close();
            //            return myDataTable;
            //        }
            //    default:
            //        MessageBox.Show("Oops! Database.SearchForItem");
            //        return null;
            //}
        }
    }
}
/*
  
    public DataTable RentalDataSelect(string select)
        {
            DataTable myDataTable = new DataTable();

            SqlCommand myCommand = connection.CreateCommand();
            myCommand.Connection = connection;

            if (select == "NOTAll")
            {
                myCommand.CommandText = "ShowAllFrom";
                myCommand.Parameters.AddWithValue("@ViewName", "CurrentRentals");
            }
            else if (select == "All")


            {
                myCommand.CommandText = "ShowAllFrom";
                myCommand.Parameters.AddWithValue("@ViewName", "AllRentals");
            }



            // myCommand.CommandText = "ShowAllFrom";
            myCommand.CommandType = CommandType.StoredProcedure;
            // myCommand.Parameters.AddWithValue("@Find", item);
            using (myDataAdapter = new SqlDataAdapter(myCommand))
            {
                connection.Open();
                myDataAdapter.Fill(myDataTable);
                connection.Close();
            }
            return myDataTable;



            //DataTable myDataTable = new DataTable();


            ////TO DO: Remove all sql queries and replace with procedure calls.
            //string sqlQuery =
            //    @"SELECT dbo.RentedMovies.RMID, dbo.Customer.FirstName, dbo.Customer.LastName, dbo.Movies.Title, dbo.RentedMovies.DateRented, dbo.RentedMovies.DateReturned FROM dbo.Customer INNER JOIN dbo.RentedMovies ON dbo.Customer.CustID = dbo.RentedMovies.CustIDFK INNER JOIN dbo.Movies ON dbo.RentedMovies.MovieIDFK = dbo.Movies.MovieID";
            //string modifier = "";
            //if (select != "All")
            //{
            //    modifier = " WHERE(dbo.RentedMovies.DateReturned IS NULL)";
            //}

            //using (myDataAdapter = new SqlDataAdapter(sqlQuery + modifier, connection))
            //{

            //    connection.Open();
            //    myDataAdapter.Fill(myDataTable);
            //    connection.Close();
            //   // connection.Dispose();
            //    return myDataTable;
            //}
        }

        //rental return if returndate==null then returndate = date. make date field for debug, note date to be system date.
        public void ReturnRental(int rentalID, DateTime date)
        {
            SqlCommand myCommand = connection.CreateCommand();
            myCommand.Connection = connection;
            myCommand.CommandText = "ReturnRental";
            myCommand.CommandType = CommandType.StoredProcedure;
            myCommand.Parameters.AddWithValue("@RentalID", rentalID);
            myCommand.Parameters.AddWithValue("@DateReturned", date);
            connection.Open();
            myCommand.ExecuteNonQuery();
            connection.Close();


            // SqlCommand myCommand=new SqlCommand("UPDATE RentedMovies set DateReturned=@Date where RMID=@rentalID");
            // //using (
            // myCommand.Connection = connection;
            //// {
            //     if (myCommand.Connection.ConnectionString != string.Empty)
            //     {
            //        // myCommand.Parameters.AddWithValue("@MovieID", movieID);
            //     myCommand.Parameters.AddWithValue("@rentalID", rentalID);
            //     myCommand.Parameters.AddWithValue("@date", date);
            //     connection.Open();
            //     myCommand.ExecuteNonQuery();
            //     connection.Close();
            //  }
            // else
            // {
            //     MessageBox.Show("no connectionstring");

            // }

        } //}
        //rental issue, take movieID, CustID, date(see above) create new rental.
        public void CreateNewRental(int movieID, int customerID, DateTime date)
        {
            try
            {
                SqlCommand myCommand = connection.CreateCommand();
                myCommand.Connection = connection;
                myCommand.CommandText = "CreateRental";
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.AddWithValue("@MovieIDFK", movieID);
                myCommand.Parameters.AddWithValue("@CustomerIDFK", customerID);
                myCommand.Parameters.AddWithValue("@DateRented", date);
                connection.Open();
                myCommand.ExecuteNonQuery();
                connection.Close();
                //SqlCommand myCommand =
                //    new SqlCommand(
                //        @"INSERT INTO RentedMovies(MovieIDFK,CustIDFK,DateRented) VALUES(@movieID,@customerID,@date)");
                //    myCommand.Connection = connection;

                //    myCommand.Parameters.AddWithValue("@MovieID", movieID);
                //    myCommand.Parameters.AddWithValue("@CustomerID", customerID);
                //    myCommand.Parameters.AddWithValue("@date", date);
                //    connection.Open();
                //    myCommand.ExecuteNonQuery();
                //    connection.Close();


            }
            catch (Exception ex)
            {
                connection.Close();
                MessageBox.Show(ex.Message);
            }
        }

        





            //MessageBox.Show(tableName + action);
            //switch (buttonName.Substring(buttonName.LastIndexOf(' ')).Trim())
            //{
            //    case "Movie":
            //        MessageBox.Show("Movie");
            //        break;
            //    case "Customer":
            //        break;
            //    case "Rental":
            //        MessageBox.Show("Rental");
            //        break;

            //}




        }

        public DataTable ReportSelect(string select)
        {
            DataTable myDataTable = new DataTable();

            SqlCommand myCommand = connection.CreateCommand();
            myCommand.Connection = connection;

            if (select == "MostPopMov")
            {
               myCommand.Parameters.AddWithValue("@ViewName", "RentalByPopularity");
            }
            else if (select == "CustMostRent")


            {
               myCommand.Parameters.AddWithValue("@ViewName", "CustomersByNumOfRentals");
            }



             myCommand.CommandText = "ShowAllFrom";
            myCommand.CommandType = CommandType.StoredProcedure;
            // myCommand.Parameters.AddWithValue("@Find", item);
            using (myDataAdapter = new SqlDataAdapter(myCommand))
            {
                connection.Open();
                myDataAdapter.Fill(myDataTable);
                connection.Close();
            }
            return myDataTable;


        }
    

    //add custDOB for age check on rental? discuss with Gary

        public bool UnitTestConnection()
        {
            DataTable myDataTable = new DataTable();
            try
            {
                string sqlQuery = "SELECT * FROM Movies";
                myDataAdapter = new SqlDataAdapter(sqlQuery, connection);
                connection.Open();
                myDataAdapter.Fill(myDataTable);
                connection.Close();

                return true;
            }
            catch
            {
                connection.Close();
                return false;
            }
        }
    }
}
*/