using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternWithService
{
    public class FeedWithSnack : IFeedTheCat
    {
        public (string brand, int quantity) FeedTheCat()
        {
            return ("Dreamies Chicken", 5);
        }

    }
}
