using Microsoft.AspNetCore.Mvc;
using OrderProcessingApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeeShirtOrderingWebApplication.Controllers
{

    [Route("/RetrievePastOrders")]
    [ApiController]
    public class RetrieveOrderController : ControllerBase
    {
        [HttpGet]
        public String RetrievePastOrders([FromForm] Order order)
        {

            return "Past Orders";
        }
    }
}
