using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern

{
    public class DryFood : ICatFood
    {
        public int GetAmountAsGram()
        {
            return 60;
        }

        public string GetFoodType()
        {
            return "dry food";
        }
    }
}
