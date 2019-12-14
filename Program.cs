using System;
using System.Collections.Generic;

namespace Bakery
{
    class Project 
    {
        public static Dictionary<int, string> pastrys = new Dictionary<int, string>() 
        {
            {0, "Croissant"},
            {1, "Puff Pastry"},
            {2, "Canoli"},
            {3, "Cream Horn"} 
        };

        public static Dictionary<int, string> bread = new Dictionary<int, string>() 
        {
            {0, "Itallian"},
            {1, "French"},
            {2, "Rye"},
            {3, "Sourdough"} 
        };
        
        public static Dictionary<int, string> drink = new Dictionary<int, string>() 
        {
            {0, "Black Tea"},
            {1, "Latte"},
            {2, "Turkish Coffee"} 
        };

        public static void Main()
        {
           
            Console.WriteLine(" ---------------------- \n Welcome to Pierre's Bakery! \n ---------------------- \n Cost of Bread: $5.00 \n Cost of Pastry: $2.00");
            Console.WriteLine(" ----------------------");
            Console.WriteLine(" Today's Scpecials:\n ----------------------\n Bread: buy 2, loaves get the 3rd free. \n Pastry: buy 1, for $2.00 or 3 for $5.00. ");
            Console.WriteLine(" ----------------------");


            Console.WriteLine(" Which pastry would you like? (0-4)");
            foreach (KeyValuePair<int, string> pastry in pastrys)  
            {  
                Console.WriteLine(" Key: {0}, Value: {1}",  
                pastry.Key, pastry.Value);
            }  
            int flovorPastry = int.Parse(Console.ReadLine());  
            Console.WriteLine(" How many Pastry's would you like?");
            int userPastry = int.Parse(Console.ReadLine());
            Pastry customerPastry = new Pastry(userPastry, 2);
            customerPastry.DeterminePricePastry(userPastry);
            

            Console.WriteLine(" Which drink would you like? (0-4)");
            foreach (KeyValuePair<int, string> drink in drink)  
            {  
                Console.WriteLine(" Key: {0}, Value: {1}",  
                drink.Key, drink.Value);
            }  
            int flovorDrink = int.Parse(Console.ReadLine()); 
            Console.WriteLine(" How many Drink's would you like?");
            int userDrink = int.Parse(Console.ReadLine()); 
            Drink customerDrink = new Drink(userDrink, 2);
            customerDrink.DeterminePriceDrink(userDrink);

            Console.WriteLine(" Which bread would you like? (0-4)");
            foreach (KeyValuePair<int, string> bread in bread)  
            {  
                Console.WriteLine(" Key: {0}, Value: {1}",  
                bread.Key, bread.Value);
            } 
            int flovorBread = int.Parse(Console.ReadLine());  
            Console.WriteLine(" How many loaves of Bread would you like?");
            int userBread = int.Parse(Console.ReadLine());
            Bread customerBread = new Bread(userBread, 2);
            customerBread.DeterminePriceBread(userBread);

            int totalPrice = (customerPastry.DeterminePricePastry(userPastry) + customerBread.DeterminePriceBread(userBread)+customerDrink.DeterminePriceDrink(userDrink));
            Console.WriteLine(" ----------------------");
            Console.WriteLine("You hava ordered: " + "" + userBread + " " + bread[flovorBread] + "(s)");
            Console.WriteLine("You hava ordered: " + "" + userPastry + " " + pastrys[flovorPastry] + "(s)");
            Console.WriteLine("You hava ordered: " + "" + userDrink + " " + drink[flovorPastry] + "(s)");
            Console.WriteLine("Total due: $" + totalPrice+ ".00");
        }
    }
}