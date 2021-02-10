using Microsoft.AspNetCore.Mvc;
using OrderProcessingApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

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


            return "order received";
        }
    }
}
