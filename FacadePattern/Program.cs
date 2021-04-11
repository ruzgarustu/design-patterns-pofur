using System;

namespace FacadePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // DailyTasksFacade acts like a wrapper for all the daily tasks of Pofur.
            // Here in the client we do not (want to) know what they are. There may be many more tasks to come as Pofur ages.
            // TaskWater, TaskWetFood and TaskLitter do not have any knowledge of the facade class, either.
            var dailyTasks = new DailyTasksFacade();
            Console.WriteLine("Completed daily tasks:");
            dailyTasks.CompleteDailyTasks();
            Console.ReadLine();
        }
    }
}
