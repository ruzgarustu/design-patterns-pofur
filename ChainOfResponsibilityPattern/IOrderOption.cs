using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public interface IOrderOption
    {
        void ProcessOrder(Order order);
    }
}
