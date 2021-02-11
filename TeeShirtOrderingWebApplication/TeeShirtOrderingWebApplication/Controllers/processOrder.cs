using Microsoft.AspNetCore.Mvc;
using OrderProcessingApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TeeShirtOrderingWebApplication.Controller;
using TeeShirtOrderingWebApplication.Model;

namespace OrderProcessingApplication.Controller
{
    [Route("ProcessNewOrder")]
    [ApiController]
    public class ProcessOrder : ControllerBase
    {
        [HttpPost]
        public RedirectResult ContentResult([FromForm] Order order)
        {
            //create unique ID for order
            Random rnd = new Random();
            int randomId = rnd.Next(1, 50000);
            order.Id = randomId.ToString();

            var validateInput = new ValidateInput();
            if (!validateInput.ValidateOrder(order))
            {
                base.Content("<div> <p><b>Connection Error</b></p> <br><br> </div> ", "text/html");
            }

            //set today's date for order
            order.Date = convertDate();

            //calculate price
            var priceCalculator = new CalculatePrices();
            order = priceCalculator.calculatePrice(order);

            //set status
            order.Status = Status.NEW;

            //Create Order
            MySQLDAO mysqlDAO = new MySQLDAO();
            String response = mysqlDAO.ConnectToMySQLDatabase(order, "CREATE");
            if (response is null)
            {
                base.Content("<div> <p><b>Connection Error</b></p> <br><br> </div> ", "text/html");
            }

            return Redirect("https://localhost:44367/SuccessfulTransaction");
        }
        public int convertDate()
        {
            DateTime currentDate = DateTime.Today;
            String dateAdjustedToSQL = currentDate.ToString("yyyyMMdd");
            return Int32.Parse(dateAdjustedToSQL);
        }
    }
}
