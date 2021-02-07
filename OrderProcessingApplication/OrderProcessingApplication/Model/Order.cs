using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderProcessingApplication.Model
{
    public class Order : Entity
        
        public Order (Guid id, DateTime date, string customerName, string customerAddress, string customerPhone, COLOR color, Size size, double price, int quantity, double totalCost, Status status, string notes)
    {

        public Date = date;
        CustomerName = customerName;
        CustomerAddress = customerAddress;
        CustomerPhone = customerPhone;
        Color = color;
        Size = size;
        Price
        Quantity
        Status
        Notes

}

public string Date { get; set; }
public string Genre { get; set; }
public int ReleaseYear { get; set; }
public string Company { get; set; }
}
