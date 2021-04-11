using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public abstract class PofurSpecialCare
    {
        public IPofurThirdPartyVisit _thirdPartyVisit;

        public abstract void TakeCareOfPofur();
    }
}
