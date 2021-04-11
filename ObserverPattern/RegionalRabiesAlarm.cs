using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class RegionalRabiesAlarm : RegionalAlarm
    {
        public RegionalRabiesAlarm(int alarmLevel) : base(alarmLevel)
        {
        }
    }
}
