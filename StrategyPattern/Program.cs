using System;

namespace StrategyPatternWithContext
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pofur is hungry, he demands food!");
            // Assume we feed Pofur with dry food from midnight to 14 PM, with snacks in afternoon and with wet food between 18PM to midnight.
            // We hold a dictionary of INutritionStrategy implementations in StrategyContext class.
            // Strategy context class also has the logic of which key value pair should be returned based on the time of the day.
            var context = new StrategyContext();
            var nutritionStrategy = context.GetStrategy(DateTime.Now.Hour);
            context.ApplyStrategy(nutritionStrategy);
            Console.ReadKey();
        }
    }
}
