using OrderProcessingApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeeShirtOrderingWebApplication.Model
{
    public class ValidateInput
    {
        public Boolean ValidateOrder(Order order)
        {

            Boolean isNotNull = IsOrderDataNotNull(order);

            Boolean isNotNegative = NumericDataIsNotNegative(order);

            Boolean isActualColor = IsActualColor(order);

            if (isNotNull && isNotNegative && isActualColor)
            {
                return true;
            }

            return false;
        }

        public Boolean IsOrderDataNotNull(Order order)
        {
            if (order is null)
            {
                return false;
            }

            if (order.CustomerAddress is null)
            {
                return false;
            }

            if (order.CustomerName is null)
            {
                return false;
            }

            if (order.CustomerPhone is null)
            {
                return false;
            }
            return true;
        }

        public Boolean NumericDataIsNotNegative(Order order)
        {
            if(order.price < 0)
            {
                return false;
            }

            if (order.Quantity <= 0)
            {
                return false;
            }

            if (order.TotalCost <= 0)
            {
                return false;
            }

            return true;
        }

        public Boolean IsActualColor(Order order)
        {
            if(order.Color.Equals(COLOR.RED) || order.Color.Equals(COLOR.ORANGE) || order.Color.Equals(COLOR.YELLOW) || order.Color.Equals(COLOR.GREEN) || order.Color.Equals(COLOR.BLUE) || order.Color.Equals(COLOR.INDIGO) || order.Color.Equals(COLOR.VIOLET))
            {
                return true;
            }
            return false;
        }
    }
}
