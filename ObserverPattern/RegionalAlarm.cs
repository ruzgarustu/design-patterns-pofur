using System;
using System.Collections.Generic;
using System.Text;

namespace ObserverPattern
{
    public abstract class RegionalAlarm
    {

        private int _alarmLevel;
        private List<IFreeCatOwner> catOwners = new List<IFreeCatOwner>();

        public int AlarmLevel { get { return _alarmLevel; }
            set
            {
                if(_alarmLevel != value)
                {
                    _alarmLevel = value;
                    NotifyObservers();
                }
            } 
        }

        public RegionalAlarm(int alarmLevel)
        {
            _alarmLevel = alarmLevel;
        }


        private void NotifyObservers()
        {
            foreach (var catOwner in catOwners)
            {
                catOwner.GetAlarmLevelUpdate(this);
            }

            Console.WriteLine("Cat owners are now notified of alarm change.");
        }

        

        public void AddObserver(IFreeCatOwner catOwner)
        {
            catOwners.Add(catOwner);
        }

        public void RemoveObserver(IFreeCatOwner catOwner)
        {
            catOwners.Remove(catOwner);
        }
    }
}
