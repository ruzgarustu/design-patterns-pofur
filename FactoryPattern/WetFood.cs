using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class WetFood : ICatFood
    {
        public int GetAmountAsGram()
        {
            return 80;
        }

        public string GetFoodType()
        {
            return "wet food";
        }
    }
}
