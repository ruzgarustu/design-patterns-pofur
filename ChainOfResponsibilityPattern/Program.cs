using System;
using System.Collections.Generic;

namespace ChainOfResponsibilityPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Assume we buy Pofur's food from supermarket or online.
            // Our first choice is supermarket if total price would be less than or equal to 30 euros. If it is more expensive, we are buying them online.

            OrderOption supermarketShopping = new Supermarket();
            OrderOption onlineShopping = new Online();

            supermarketShopping.SetNextFeasibleOption(onlineShopping);

            var shoppingListItems = new List<CatFood>()
            {
                new CatFood() { brand = "MjamMjam", amount = 2, basePrice = 3.80m },
                new CatFood() { brand = "Purizon", amount = 5, basePrice = 6.00M }
            };

            var order = new Order(shoppingListItems);
            supermarketShopping.ProcessOrder(order);

            Console.ReadLine();

        }
    }
}
