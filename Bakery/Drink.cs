using System;
using System.Collections.Generic;

namespace Bakery
{
    public class Drink
    {
        public int QuantityDrink { get; set;}    
        public int TotalDrink { get; set;}
        public int PerDrink { get; set; }

        public Drink(int quantityPatry, int totalDrink)
        {
            QuantityDrink = quantityPatry;
            TotalDrink = totalDrink;
            PerDrink = 5;
        }
        public int DeterminePriceDrink(int quantityPatry) 
        {
            TotalDrink= 0;
            TotalDrink= (QuantityDrink * PerDrink);
            if (QuantityDrink == 3)
            {
                TotalDrink = 10;
            }
            return TotalDrink;
        }
    }
}