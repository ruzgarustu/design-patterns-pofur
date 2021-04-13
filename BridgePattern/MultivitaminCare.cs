using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public class MultivitaminCare : PofurSpecialCare
    {
        public override void TakeCareOfPofur()
        {
            this.ThirdPartyVisit.VisitDaily("multivitamin");
        }
    }
}
