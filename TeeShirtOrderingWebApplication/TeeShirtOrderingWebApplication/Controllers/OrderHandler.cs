using Microsoft.AspNetCore.Mvc;
using OrderProcessingApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeeShirtOrderingWebApplication.Controllers
{

    [Route("OrderHandler")]
    [ApiController]
    public class OrderHandler : ControllerBase
    {
        [HttpPost]
        public String ProcessNewOrder([FromBody] Order order)
        {
            return "order received";
        }
    }
}
