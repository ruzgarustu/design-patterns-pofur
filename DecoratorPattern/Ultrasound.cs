using DecoratorPattern.BaseTreatment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class Ultrasound : TreatmentDecorator
    {
        public Ultrasound(ITreatment visit):base(visit)
        {
            _desc = "Ultrasound";
            _cost = 115.00M;
        }
    
    }
}
