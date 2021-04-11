using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.BaseTreatment
{
    public interface ITreatment
    {
        string GetDescription();
        decimal GetCost();
    }
}
