using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternWithContext
{
    public class DryFoodStrategy : INutritionStrategy
    {
        public (string brand, int quantity) FeedTheCat()
        {
            return ("Purizon Lamb", 100);
        }
    }
}
