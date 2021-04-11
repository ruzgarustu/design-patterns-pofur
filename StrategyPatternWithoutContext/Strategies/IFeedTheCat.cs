using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternWithService
{
    public interface IFeedTheCat
    {
        (string brand, int quantity) FeedTheCat();
    }
}
