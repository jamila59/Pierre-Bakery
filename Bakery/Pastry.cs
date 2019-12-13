using System;
using System.Collections.Generic;

namespace Bakery
{
    public class Pastry 
    {
        public int QuantityPastry { get; set;}    
        public int TotalPastry { get; set;}
        public int PerPastry { get; set; }

        public Pastry(int quantityPatry, int totalPastry)
        {
            QuantityPastry = quantityPatry;
            TotalPastry = totalPastry;
            PerPastry = 2;
        }
        public int DeterminePricePastry(int quantityPatry) 
        {
            TotalPastry= 0;
            TotalPastry= (QuantityPastry * PerPastry);
            if (QuantityPastry == 3)
            {
                TotalPastry --;
            }
            return TotalPastry;
        }
    }
}