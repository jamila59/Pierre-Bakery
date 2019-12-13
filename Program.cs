using System;
using System.Collections.Generic;

namespace Pastry.Bread
{
    class Project 
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Pierre's Bakery! \n Cost of Bread: $5 \n Cost of Pastry: $2 \n Would you like to look at our specials menu? (Y/N)");
            string scpecials = Console.ReadLine();
            if (scpecials == "Y")
            {
                Console.WriteLine("Today's Scpecials:\n Bread: buy 2 loaves get the 3rd free. \n Pastry: buy 1 for $2 or 3 for $5. ");
            }
            else
            {
                Console.WriteLine("How many loaves of Bread would you like?");
                int userBread = Console.ReadLine();
                Console.WriteLine("How many loaves of Bread would you like?");
                int userPastry = int.Parse(Console.ReadLine());

            }
        }
    }
}