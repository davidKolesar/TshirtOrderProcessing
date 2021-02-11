using Microsoft.AspNetCore.Mvc;
using OrderProcessingApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeeShirtOrderingWebApplication.Controller;
using TeeShirtOrderingWebApplication.Model;

namespace TeeShirtOrderingWebApplication.Controllers
{

    [Route("/RetrievePastOrders")]
    [ApiController]
    public class RetrieveOrderController : ControllerBase
    {
        [HttpGet]
        public ContentResult RetrievePastOrders([FromForm] Order order)
        {
            MySQLDAO mysqlDAO = new MySQLDAO();
            String resultsTable = mysqlDAO.ConnectToMySQLDatabase(order, "READ");
         
            return base.Content("<div> " + resultsTable + "</div> ", "text/html");
        }
    }
}
