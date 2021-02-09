using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderProcessingApplication.Model
{
    public class Order : Entity
    {
        
        public Order(Guid id, DateTime date, string customerName, string customerAddress, string customerPhone, COLOR color, Size size, double price, int quantity, double totalCost, Status status, string notes)
        {

            DateTime Date = date;
            string CustomerName = customerName;
            string CustomerAddress = customerAddress;
            string CustomerPhone = customerPhone;
            COLOR Color = color;
            Size Size = size;
            double Price = price;
            int Quantity = quantity;
            Status Status = status;
            double TotalCost = totalCost;
            string Notes = notes;

        }

        public DateTime Date { get; set; }
        string CustomerName { get; set; }
        string CustomerAddress { get; set; }
        string CustomerPhone { get; set; }
        COLOR Color { get; set; }
        Size size { get; set; }
        double price { get; set; }
        int Quantity { get; set; }
        Status Status { get; set; }
        double TotalCost { get; set; }
        string Notes { get; set; }
    }
}