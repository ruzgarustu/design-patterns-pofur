using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class SnackFood : ICatFood
    {
        public int GetAmountAsGram()
        {
            return 5;
        }

        public string GetFoodType()
        {
            return "snacks";
        }
    }
}
