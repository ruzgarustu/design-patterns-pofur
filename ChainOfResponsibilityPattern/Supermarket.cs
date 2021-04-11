using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class Supermarket : OrderOption
    {
        public override void ProcessOrder(Order order)
        {
            if(order.totalAmount <= 30.00M)
            {
                Console.WriteLine("Buy Pofur's shopping list from supermarket.");
            }

            else
            {
                if(nextFeasibleOption != null)
                {
                    nextFeasibleOption.ProcessOrder(order);
                }
            }
        }
    }
}
