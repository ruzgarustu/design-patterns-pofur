using DecoratorPattern.BaseTreatment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{ 
    public class RoutineControl : TreatmentDecorator
    {
        public RoutineControl(ITreatment visit):base(visit)
        {
            _desc = "Routine Check";
            _cost = 10.00M;
        }
   
    }
}
