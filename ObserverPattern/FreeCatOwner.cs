using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public class FreeCatOwner : IFreeCatOwner
    {
        private string _ownerName;
        private int _warningAlarmLevel;

        public FreeCatOwner(string ownerName, int warningAlarmLevel)
        {
            _ownerName = ownerName;
            _warningAlarmLevel = warningAlarmLevel;
        }

        public void GetAlarmLevelUpdate(RegionalAlarm alarm)
        {
            Console.WriteLine($"Notified cat owner {_ownerName} of the update in {alarm.GetType().Name} to {alarm.AlarmLevel}");

            if (alarm.AlarmLevel < _warningAlarmLevel)
                Console.WriteLine($"Dear {_ownerName}, there is now less danger for your cat to go around freely!");
            else
                Console.WriteLine($"Dear {_ownerName}, alarm level is now higher than you have set for your cat as maximum alarm level ({_warningAlarmLevel}). Please keep your cat indoors!");
        }
    }
}
