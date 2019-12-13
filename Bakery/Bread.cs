using System;
using System.Collections.Generic;

namespace Bakery
{
    public class Bread 
    {
        public int QuantityBread { get; set;}    
        public int TotalBread { get; set;}
        public int PerBread { get; set; }

        public Bread(int quantityPatry, int totalBread)
        {
            QuantityBread = quantityPatry;
            TotalBread = totalBread;
            PerBread = 5;
        }
        public int DeterminePriceBread(int quantityPatry) 
        {
            TotalBread= 0;
            TotalBread= (QuantityBread * PerBread);
            if (QuantityBread == 3)
            {
                TotalBread = 10;
            }
            return TotalBread;
        }
    }
}