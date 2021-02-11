using MySql.Data.MySqlClient;
using OrderProcessingApplication.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeeShirtOrderingWebApplication.Controller
{
    public class MySQLDAO
    {
        public String ConnectToMySQLDatabase(Order order, String query)
        {
                var dbCon = Data.DBConnection.Instance();
                dbCon.Server = "127.0.0.1";
                dbCon.DatabaseName = "shirt_ordering_application";
                dbCon.UserName = "root";
                dbCon.Password = "password";
                dbCon.Port = "3306";

                if (dbCon.IsConnect())
                {
                    return determineQuery(dbCon, order, query);
                }
                return null;
            }

        public void ProcessQuery(Data.DBConnection dbCon, Order order, String sqlQuery)
        {
            if(dbCon.Connection.State != ConnectionState.Open)
            {
                dbCon.Connection.Open();
            }

            MySqlCommand cmd = new MySqlCommand(sqlQuery, dbCon.Connection);
            var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                string someStringFromColumnZero = reader.GetString(0);
                string someStringFromColumnOne = reader.GetString(1);
                Console.WriteLine(someStringFromColumnZero + "," + someStringFromColumnOne);
            }
            reader.Close();
            dbCon.Close();
            dbCon = null;
        }


        public String RetrieveAllOrders(Data.DBConnection dbCon)
        {
            if (dbCon.Connection.State != ConnectionState.Open)
            {
                dbCon.Connection.Open();
            }

            string query = "SELECT * FROM order_table;";
            MySqlCommand cmd = new MySqlCommand(query, dbCon.Connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            string tableId = "<table id='resultsTable' table, td { border: 3px solid black; border - collapse: collapse; }>";
            string tableRowOpen = "<tr>";
            string tableDataOpen = "<td>";
            string tableHeadOpen = "<th>";
            string tableRowClose = "</tr>";
            string tableDataClose = "</td>";
            string tableHeadClose = "</th>";


            StringBuilder sb = new StringBuilder();
            sb.Append(tableId);
            while (reader.Read())
            {
                sb.Append(tableRowOpen);
                sb.Append(tableDataOpen);
                sb.Append(tableHeadOpen);
                sb.Append(reader.GetString(0));
                sb.Append(tableHeadClose);
                sb.Append(tableDataClose);

                sb.Append(tableHeadOpen);
                sb.Append(reader.GetString(1));
                sb.Append(tableHeadClose);
                sb.Append(tableDataClose);

                sb.Append(tableHeadOpen);
                sb.Append(reader.GetString(2));
                sb.Append(tableHeadClose);
                sb.Append(tableDataClose);

                sb.Append(tableHeadOpen);
                sb.Append(reader.GetString(3));
                sb.Append(tableHeadClose);
                sb.Append(tableDataClose);

                sb.Append(tableHeadOpen);
                sb.Append(reader.GetString(4));
                sb.Append(tableHeadClose);
                sb.Append(tableDataClose);

                sb.Append(tableHeadOpen);
                sb.Append(reader.GetString(5));
                sb.Append(tableHeadClose);
                sb.Append(tableDataClose);

                sb.Append(tableHeadOpen);
                sb.Append(reader.GetString(6));
                sb.Append(tableHeadClose);
                sb.Append(tableDataClose);

                sb.Append(tableHeadOpen);
                sb.Append(reader.GetString(7));
                sb.Append(tableHeadClose);
                sb.Append(tableDataClose);

                sb.Append(tableHeadOpen);
                sb.Append(reader.GetString(8));
                sb.Append(tableHeadClose);
                sb.Append(tableDataClose);

                sb.Append(tableHeadOpen);
                sb.Append(reader.GetString(9));
                sb.Append(tableHeadClose);
                sb.Append(tableDataClose);

                sb.Append(tableHeadOpen);
                sb.Append(reader.GetString(10));
                sb.Append(tableHeadClose);
                sb.Append(tableDataClose);

                sb.Append(tableHeadOpen);
                sb.Append(reader.GetString(11));
                sb.Append(tableHeadClose);
                sb.Append(tableDataClose);
                sb.Append(tableRowClose);
            }
            string resultsTable = sb.ToString();
            reader.Close();
            dbCon.Close();
            dbCon = null;

            return resultsTable;
        }

        public String determineQuery(Data.DBConnection dbCon, Order order, String query)
        {

            string addQuery = "INSERT INTO `order_table`(idorder_table, date, name, address, phone, color, size, price, quantity, total_cost, status, notes) VALUES(" + "'" + order.Id + "', " + order.Date + ", '" + order.CustomerName + "', '" + order.CustomerAddress + "', " + order.CustomerPhone + ", '" + order.Color + "', '" + order.size + "', " + order.price + ", " + order.Quantity + ", " + order.TotalCost + ", '" + order.Status + "', '" + order.Notes + "' )";

            string removeQuery = "DELETE FROM order_table WHERE idorder_table = " + order.Id;

            string updateQuery = "UPDATE order_table SET date = " + order.Date + ", name = '" + order.CustomerName + "', address = '" + order.CustomerAddress + "', phone = " + order.CustomerPhone + ", color = '" + order.Color + "', size = '" + order.size + "', price = " + order.price + ", quantity = " + order.Quantity + ", total_cost =" + order.TotalCost + ", status = '" + order.Status + "', notes ='" + order.Notes + "' WHERE idorder_table = " + order.Id;

            switch (query)
            {
                case "CREATE":
                    ProcessQuery(dbCon, order, addQuery);
                    return "success";
                case "READ":
                    String success = RetrieveAllOrders(dbCon);
                    return success;
                case "UPDATE":
                    ProcessQuery(dbCon, order, updateQuery);
                    return "success";
                case "DELETE":
                    ProcessQuery(dbCon, order, removeQuery);
                    break;
                default:
                    return null;
            }
            return null;
        }
    }
}
