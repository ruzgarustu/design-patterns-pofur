using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public class Online : OrderOption
    {
        public override void ProcessOrder(Order order)
        {
            if (order.totalAmount > 30.00M)
            {
                Console.WriteLine("Buy Pofur's shopping list online.");
            }

            else
            {
                if (nextFeasibleOption != null)
                {
                    nextFeasibleOption.ProcessOrder(order);
                }
            }
        }

    }
}
