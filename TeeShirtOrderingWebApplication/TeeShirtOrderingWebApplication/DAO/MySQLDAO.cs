using MySql.Data.MySqlClient;
using OrderProcessingApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeeShirtOrderingWebApplication.Controller
{
    public class MySQLDAO
    {
        private static String SELECT_ORDER = "SELECT idorder_table, name FROM order_table";


        public Boolean AddOrder(Order order)
        {
            var dbCon = Data.DBConnection.Instance();
            dbCon.Server = "127.0.0.1";
            dbCon.DatabaseName = "shirt_ordering_application";
            dbCon.UserName = "root";
            dbCon.Password = "password";
            dbCon.Port = "3306";
            Boolean success = false;

            if (dbCon.IsConnect())
            {
                success = executeQuery(dbCon, order);
            }
            return success;
        }

        public Boolean executeQuery(Data.DBConnection dbCon, Order order)
        {

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

        private String CreateQuery()
        {

            INSERT INTO `order_table`(idorder_table, date, name, address, phone, color, size, price, quantity, total_cost, status, notes) VALUES(0, 20210411, "test", "test address", 1111111111, "pink", "large", 1.00, 1, 1.00, "completed", "This is test data");

        }

    }

}
