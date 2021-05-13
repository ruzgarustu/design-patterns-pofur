using System;
using System.Threading;

namespace MementoPattern
{
    public class Program
    {
        // Assume we want to store a happy and healthy moment of Pofur as snapshot and want to re-live it when we are old (given there is suitable technology for that!)
        // We made a snapshot of Pofur when he was 4 years old and 5 kg.
        // Although we updated the status one step later, we are able to override it after restoring the snapshot. We can kind of undo the status.

        public static void Main(string[] args)
        {
            var status = new PofurStatus();
            status.PofurWeight = 5;
            status.PofurAge = 4;
            status.SnapshotDate = DateTime.UtcNow;

            var careTaker = new SnapshotCareTaker();
            careTaker.CheckPointOfHappiness = status.StoreHappyMoment(status);
            Console.WriteLine($"Happy moment of {status.PofurWeight} kg. and {status.PofurAge} years old Pofur as of {status.SnapshotDate} stored!");

            Thread.Sleep(1000);

            // Assume Pofur gained 1 kg. after 5 years
            status.PofurWeight = 6;
            status.PofurAge = 9;
            status.SnapshotDate = DateTime.UtcNow.AddYears(5);
            Console.WriteLine($"Updated status of Pofur:  {status.PofurWeight} kg. and {status.PofurAge} years old as of {status.SnapshotDate}.");
            Thread.Sleep(1000);


            status.RestoreHappyMoment(careTaker.CheckPointOfHappiness);
            Console.WriteLine($"Happy moment of {status.PofurWeight} kg. and {status.PofurAge} years old Pofur as of {status.SnapshotDate} restored!");

        }
    }
}
