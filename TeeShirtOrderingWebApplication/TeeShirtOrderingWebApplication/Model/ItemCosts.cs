using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TeeShirtOrderingWebApplication.Model
{
    public class ItemCosts
    {
        double child = 5.00;
        double small = 8.00;
        double medium = 12.00;
        double large = 14.00;
        double extraLarge = 18.00;

        public double Child { get; }
        public double Small { get; }
        public double Medium { get; }
        public double Large { get; }
        public double ExtraLarge { get; }

    }
}
