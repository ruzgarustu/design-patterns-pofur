using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternWithContext
{
    public interface INutritionStrategy
    {
        (string brand, int quantity) FeedTheCat();
    }
}
