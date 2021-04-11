using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class CatSitterVisit : IPofurThirdPartyVisit
    {
        public void VisitDaily(string careType)
        {
            Console.WriteLine($"During our holiday, Pofur is visited by our catsitter and given {careType} daily.");
        }
    }
}
