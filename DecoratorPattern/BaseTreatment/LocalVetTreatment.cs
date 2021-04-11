using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.BaseTreatment
{
    public class LocalVetTreatment : ITreatment
    {
        public decimal GetCost()
        {
            return 50.00M;
        }

        public string GetDescription()
        {
            return "Local Vet Visit";
        }
    }
}
