using Microsoft.AspNetCore.Mvc;
using OrderProcessingApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TeeShirtOrderingWebApplication.Controller;

namespace OrderProcessingApplication.Controller
{
    [Route("ProcessNewOrder")]
    [ApiController]
    public class processOrder : ControllerBase
    {
        [HttpPost]
        public String ProcessNewOrder([FromForm] Order order)
        {
            //create unique ID for order
            String longGuid  = Guid.NewGuid().ToString("N");
            order.Id = longGuid.Substring(0, 5);

            //set today's date for order
            order.Date = convertDate();

            //calculate price
            order = calculatPrices(order);

            //set status
            order.Status = Status.NEW;

            //Create Order
            MySQLDAO mysqlDAO = new MySQLDAO();
            mysqlDAO.ConnectToMySQLDatabase(order, "CREATE");

            return "order received";
        }

        public Boolean validateOrder([FromForm] Order order)
        {
            return true;
        }

        public Order calculatPrices(Order order)
        {
            double totalCost = 0;
            double CHILD_COST = 5.00;
            double SMALL_COST = 8.00;
            double MEDIUM_COST = 10.00;
            double LARGE_COST = 14.00;
            double EXTRA_COST = 18.00;

            Dictionary<Size, double> sizeToPrice = new Dictionary<Size, double>();
            sizeToPrice.Add(Size.CHILD, CHILD_COST);
            sizeToPrice.Add(Size.SMALL, SMALL_COST);
            sizeToPrice.Add(Size.MEDIUM, MEDIUM_COST);
            sizeToPrice.Add(Size.LARGE, LARGE_COST);
            sizeToPrice.Add(Size.EXTRALARGE, EXTRA_COST);

            foreach (KeyValuePair<Size, double> entry in sizeToPrice)
            {
                if (order.size.Equals(entry.Key))
                {
                    order.price = entry.Value;
                    totalCost = totalCost + (entry.Value * order.Quantity);
                }
            }

            order.TotalCost = totalCost;
            return order;
        }

        public int convertDate()
        {
            DateTime currentDate = DateTime.Today;
            String dateAdjustedToSQL = currentDate.ToString("yyyyMMdd");
            return  Int32.Parse(dateAdjustedToSQL);
        }
    }
}
