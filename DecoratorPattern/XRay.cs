using DecoratorPattern.BaseTreatment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class XRay : TreatmentDecorator
    {
        public XRay(ITreatment visit):base(visit)
        {
            _desc = "X-Ray";
            _cost = 64.00M;
        }

    }
}
