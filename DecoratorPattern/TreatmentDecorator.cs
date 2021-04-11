using DecoratorPattern.BaseTreatment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{ 
    public abstract class TreatmentDecorator : ITreatment
    {
        private ITreatment visit;

        protected string _desc = "undefined";
        protected decimal _cost = 0.00M;

        public TreatmentDecorator(ITreatment visit)
        {
            this.visit = visit;
        }

        public string GetDescription()
        {
            return string.Format("{0}, {1}", visit.GetDescription(), _desc);
        }

        public decimal GetCost()
        {
            return visit.GetCost() + _cost;
        }
    }
}
