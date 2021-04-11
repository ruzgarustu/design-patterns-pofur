using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.BaseTreatment
{
    public class UrgentClinicTreatment : ITreatment
    {
        public decimal GetCost()
        {
            return 50.00M;
        }

        public string GetDescription()
        {
            return "Urgent Animal Clinic Visit";
        }
    }
}
