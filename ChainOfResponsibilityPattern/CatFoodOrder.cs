using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class Order
    {
        public decimal totalAmount = 0.00M;
        public Order(List<CatFood> shoppingList)
        {
            foreach (var item in shoppingList)
            {
                totalAmount += item.basePrice * item.amount;
                Console.WriteLine($"Pofur needs {item.amount} {item.brand}");
            }
            Console.WriteLine($"Total amount of this order would be {totalAmount}"); 

        }
    }

    public class CatFood
    {
        public string brand;
        public decimal basePrice;
        public int amount;
    }
}
