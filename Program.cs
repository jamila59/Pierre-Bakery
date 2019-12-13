using System;
using System.Collections.Generic;

namespace Bakery
{
    class Project 
    {
        public static Dictionary<int, string> picks = new Dictionary<int, string>() 
        {
            {0, "Croissant"},
            {1, "Puff Pastry"},
            {2, "Canoli"},
            {3, "Cream Horn"} 
        };

        public static Dictionary<int, string> picks2 = new Dictionary<int, string>() 
        {
            {0, "Itallian"},
            {1, "French"},
            {2, "Rye"},
            {3, "Sourdough"} 
        };

        public static void Main()
        {
           
            Console.WriteLine("Welcome to Pierre's Bakery! \n ---------------------- \n Cost of Bread: $5 \n Cost of Pastry: $2");

            
            Console.WriteLine("----------------------");
            Console.WriteLine("Today's Scpecials:\n ----------------------\nBread: buy 2 loaves get the 3rd free. \nPastry: buy 1 for $2 or 3 for $5. ");
            Console.WriteLine("----------------------");

            Console.WriteLine("Which pastry would you like? (0-4)");
            foreach (KeyValuePair<int, string> pick in picks)  
            {  
                Console.WriteLine("Key: {0}, Value: {1}",  
                pick.Key, pick.Value);
            }  

            string flovorPastry = Console.ReadLine();  
            Console.WriteLine(flovorPastry);

            Console.WriteLine("How many Pastry's would you like?");
            int userPastry = int.Parse(Console.ReadLine());
            Pastry customerPastry = new Pastry(userPastry, 2);
            customerPastry.DeterminePricePastry(userPastry);

            Console.WriteLine("Which bread would you like? (0-4)");
            foreach (KeyValuePair<int, string> pick2 in picks2)  
            {  
                Console.WriteLine("Key: {0}, Value: {1}",  
                pick2.Key, pick2.Value);
            } 

            string flovorBread = Console.ReadLine();  
            Console.WriteLine(flovorBread); 

            Console.WriteLine("How many loaves of Bread would you like?");
            int userBread = int.Parse(Console.ReadLine());
            Bread customerBread = new Bread(userBread, 2);
            customerBread.DeterminePriceBread(userBread);

            int totalPrice = (customerPastry.DeterminePricePastry(userPastry) + customerBread.DeterminePriceBread(userBread));
            Console.WriteLine("----------------------");
            Console.WriteLine("Total due: $" + totalPrice);
   
           
        }
    }
}