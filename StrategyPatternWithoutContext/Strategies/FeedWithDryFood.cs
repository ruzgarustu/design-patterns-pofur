using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternWithService
{
    public class FeedWithDryFood : IFeedTheCat
    {
        public (string brand, int quantity) FeedTheCat()
        {
            return ("Purizon Lamb", 100);
        }
    }
}
