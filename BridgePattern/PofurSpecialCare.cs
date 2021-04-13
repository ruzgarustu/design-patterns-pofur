using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public abstract class PofurSpecialCare
    {
        public IPofurThirdPartyVisit ThirdPartyVisit;

        public abstract void TakeCareOfPofur();
    }
}
