using DecoratorPattern.BaseTreatment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Vaccine : TreatmentDecorator
    {
        public Vaccine(ITreatment visit):base(visit)
        {
            _desc = "Vaccine";
            _cost = 34.00M;
        }

    }
 
}
