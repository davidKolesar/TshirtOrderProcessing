using Microsoft.AspNetCore.Mvc;
using OrderProcessingApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TeeShirtOrderingWebApplication.Controller;

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
            mysqlDAO.ConnectToMySQLDatabase(order, "READ");

            return base.Content("<div>Hello</div>", "text/html");
        }
    }
}
