using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class FoodFactory
    {
        public static ICatFood GetFoodForCat(DateTime foodTime)
        {
            var foodHour = foodTime.Hour;

            if (foodHour <= 12)
                return new DryFood();

            else if (foodHour <= 15)
                return new SnackFood();

            else
                return new WetFood();
        }
    }
}
