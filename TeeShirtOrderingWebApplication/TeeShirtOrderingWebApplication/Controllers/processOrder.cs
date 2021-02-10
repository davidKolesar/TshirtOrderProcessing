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
            order.Id = new Guid();
            //set today's date for order
            order.Date = DateTime.Today;

            MySQLDAO mysqlDAO = new MySQLDAO();

            //Create Order
            mysqlDAO.AddOrder(order)

            return "order received";
        }

        public Boolean validateOrder ([FromForm] Order order)
        {
            return true;
        }
    }
}
