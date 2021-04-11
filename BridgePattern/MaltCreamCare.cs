using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class MaltCreamCare : PofurSpecialCare
    {
        public override void TakeCareOfPofur()
        {
            this._thirdPartyVisit.VisitDaily("malt cream");
        }
    }
}
