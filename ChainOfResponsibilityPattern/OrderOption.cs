using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public abstract class OrderOption : IOrderOption
    {
        // classes that derive from OrderOption should have a successor that could be configured (not necessarily) in client 
        protected OrderOption nextFeasibleOption;
        
        public void SetNextFeasibleOption(OrderOption nextOption)
        {
            nextFeasibleOption = nextOption;
        }

        public abstract void ProcessOrder(Order order);
    }
}
