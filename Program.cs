using System;
using System.Collections.Generic;

namespace Pastry.Bread
{
    class Project 
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Pierre's Bakery! \n Cost of Bread: $5 \n Cost of Pastry: $3 \n Would you like to look at our specials menu?");
            string scpecials = Console.ReadLine();
            if (scpecials == "Yes")
            {
                Console.WriteLine("Today's Scpecials:\n Bread: buy 2 loaves of get the 3rd free \n Pastry: buy 1 for $2 or 3 for $5 ");
            }
            else
            {
                Console.WriteLine("What would you like to order?");
            }
        }
    }
}