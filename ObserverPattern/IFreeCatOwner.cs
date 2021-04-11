using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public interface IFreeCatOwner
    {
        void GetAlarmLevelUpdate(RegionalAlarm alarm);
    }
}
