using System;
using System.Collections.Generic;

namespace Bakery
{
    class Project 
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to Pierre's Bakery! \n Cost of Bread: $5 \n Cost of Pastry: $2 \n Let's take a look at our specials menu? ");
            
                Console.WriteLine("Today's Scpecials:\n Bread: buy 2 loaves get the 3rd free. \n Pastry: buy 1 for $2 or 3 for $5. ");
            
                Console.WriteLine("How many loaves of Bread would you like?");
                int userBread = int.Parse(Console.ReadLine());
                Bread customerBread = new Bread(userBread, 2);
                customerBread.DeterminePriceBread(userBread);

                Console.WriteLine("How many Pastry's would you like?");
                int userPastry = int.Parse(Console.ReadLine());
                Pastry customerPastry = new Pastry(userPastry, 2);
                customerPastry.DeterminePricePastry(userPastry);

                // Console.WriteLine(Pastry.TotalPastry);

        
        }
    }
}