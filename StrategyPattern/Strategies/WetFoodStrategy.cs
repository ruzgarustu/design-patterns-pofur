using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternWithContext
{
    public class WetFoodStrategy : INutritionStrategy
    {
        public (string brand, int quantity) FeedTheCat()
        {
            return ("MjamMjam", 150);
        }

        
    }
}
