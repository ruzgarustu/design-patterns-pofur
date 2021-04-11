using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class NeighbourVisit : IPofurThirdPartyVisit
    {
        public void VisitDaily(string careType)
        {
            Console.WriteLine($"During our holiday, Pofur is visited by our neighbor and given {careType} daily.");
        }
    }
}
