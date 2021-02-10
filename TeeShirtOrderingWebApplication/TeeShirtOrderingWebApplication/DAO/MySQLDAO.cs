using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeeShirtOrderingWebApplication.Controller
{
    public class MySQLDAO
    {

        public void connectToDatabase(string query)
        {
            var dbCon = Data.DBConnection.Instance();
            dbCon.Server = "127.0.0.1";
            dbCon.DatabaseName = "shirt_ordering_application";
            dbCon.UserName = "root";
            dbCon.Password = "password";
            dbCon.Port = "3306";

            if (dbCon.IsConnect())
            {
                executeQuery(dbCon);
            }
        }

        public Boolean executeQuery(Data.DBConnection dbCon)
        {
            //suppose col0 and col1 are defined as VARCHAR in the DB
            string query = "SELECT idorder_table, name FROM order_table";
            MySqlCommand cmd = new MySqlCommand(query, dbCon.Connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string someStringFromColumnZero = reader.GetString(0);
                string someStringFromColumnOne = reader.GetString(1);
                Console.WriteLine(someStringFromColumnZero + "," + someStringFromColumnOne);
            }
            dbCon.Close();
            return true;
        }
    }
}
