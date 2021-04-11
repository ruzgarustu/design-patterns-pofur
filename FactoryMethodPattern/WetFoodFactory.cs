using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class WetFoodFactory : FoodFactory
    {
        protected override ICatFood ArrangeFoodForCat()
        {
            return new WetFood();
        }
    }
}
