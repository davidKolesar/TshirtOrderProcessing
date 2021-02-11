using OrderProcessingApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeeShirtOrderingWebApplication.Model
{
    public class CalculatePrices
    {
        public Order calculatePrice(Order order) {
            double totalCost = 0;
            double CHILD_COST = 5.00;
            double SMALL_COST = 8.00;
            double MEDIUM_COST = 10.00;
            double LARGE_COST = 14.00;
            double EXTRA_COST = 18.00;

            Dictionary<Size, double> sizeToPrice = new Dictionary<Size, double>();
            sizeToPrice.Add(Size.CHILD, CHILD_COST);
            sizeToPrice.Add(Size.SMALL, SMALL_COST);
            sizeToPrice.Add(Size.MEDIUM, MEDIUM_COST);
            sizeToPrice.Add(Size.LARGE, LARGE_COST);
            sizeToPrice.Add(Size.EXTRALARGE, EXTRA_COST);

            foreach (KeyValuePair<Size, double> entry in sizeToPrice)
            {
                if (order.size.Equals(entry.Key))
                {
                    order.price = entry.Value;
                    totalCost = totalCost + (entry.Value * order.Quantity);
                }
            }

            order.TotalCost = totalCost;
            return order;
        }
    }
}
