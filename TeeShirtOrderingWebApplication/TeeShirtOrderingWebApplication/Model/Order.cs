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
        public DateTime Date { get; set; }
        [BindProperty]
        public string CustomerName { get; set; }
        [BindProperty]
        public string CustomerAddress { get; set; }
        [BindProperty]
        public string CustomerPhone { get; set; }
        [BindProperty]
        public COLOR Color { get; set; }
        [BindProperty]
        public Size size { get; set; }
        [BindProperty]
        public double price { get; set; }
        public int Quantity { get; set; }
        public Status Status { get; set; }
        public double TotalCost { get; set; }
        [BindProperty]
        public string Notes { get; set; }
    }
}