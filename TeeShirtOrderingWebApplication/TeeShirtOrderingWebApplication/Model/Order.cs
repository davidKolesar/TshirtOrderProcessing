using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderProcessingApplication.Model
{
    public class Order
    {
        
        public Guid Id { get; set; }
        [BindProperty]
        public DateTime Date { get; set; }
        [BindProperty]
        string CustomerName { get; set; }
        [BindProperty]
        string CustomerAddress { get; set; }
        [BindProperty]
        string CustomerPhone { get; set; }
        [BindProperty]
        COLOR Color { get; set; }
        [BindProperty]
        Size size { get; set; }
        [BindProperty]
        double price { get; set; }
        int Quantity { get; set; }
        Status Status { get; set; }
        double TotalCost { get; set; }
        [BindProperty]
        string Notes { get; set; }
    }
}