using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternWithContext
{
    public class SnackStrategy : INutritionStrategy
    {
        public (string brand, int quantity) FeedTheCat()
        {
            return ("Dreamies Chicken", 5);
        }

    }
}
