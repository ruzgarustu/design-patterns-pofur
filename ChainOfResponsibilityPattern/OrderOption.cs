using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public abstract class OrderOption : IOrderOption
    {
        
        protected OrderOption nextFeasibleOption;
        
        public void SetNextFeasibleOption(OrderOption nextOption)
        {
            nextFeasibleOption = nextOption;
        }

        public abstract void ProcessOrder(Order order);
    }
}
