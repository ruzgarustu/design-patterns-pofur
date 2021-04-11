using System;

namespace ObserverPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Assume my neighbor Shrek and I have cats that roam around the neighborhood freely.
            // But as free cat owners, we want to get a notification whenever there is a change in rabies alarm level of the neighborhood.
            // Shrek has a giant cat like himself, so he is not much worried about his cat and his alarm threshold is 4.
            // My cat is kind of silly, so as long as alarm level is set to 3 or more I want to keep my cat indoors.
            var rabiesAlarm = new RegionalRabiesAlarm(2);

            rabiesAlarm.AddObserver(new FreeCatOwner("Shrek", 4));
            rabiesAlarm.AddObserver(new FreeCatOwner("Funda", 2));

            // No update happens as the inital level was already 2
            rabiesAlarm.AlarmLevel = 2;

            // observers are now notified
            rabiesAlarm.AlarmLevel = 5;
            rabiesAlarm.AlarmLevel = 3;

            Console.ReadLine();

        }
    }
}
