using System;
using System.Collections.Generic;

namespace TemplateMethodPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //As long as Pofur is healthy and happy, he has similar day-to-day routines: Eating his food, playing, sleeping and visiting his toilet.
            //How he plays and sleeps are based heavily on weather: If it is a summer day (or a relatively warm day) he prefers to sleep in his hammock in balcony and play with butterflies.
            //If it is a colder day, he sleeps on his human's lap and plays with snowflakes on balcony.

            //Notice how PofurDailyRoutine abstract class defines a template for his routine and implements the eating food & going to toilet routines, which stays the same no matter how the weather is.
            //SummerDailyRoutine and WinterDailyRoutine classes that derive from this abstract class implement the sleeping & playing routines that differ based on the weather conditions.

            var dailyRoutinesOfPofur = new List<PofurDailyRoutine>();

            var summerDay = new SummerDailyRoutine();
            var winterDay = new WinterDailyRoutine();

            dailyRoutinesOfPofur.Add(summerDay);
            dailyRoutinesOfPofur.Add(winterDay);

            foreach (var dailyRoutine in dailyRoutinesOfPofur)
            {
                Console.WriteLine(dailyRoutine.GetType().Name);
                dailyRoutine.ProceedDailyRoutine();
            }


        }
    }
}
