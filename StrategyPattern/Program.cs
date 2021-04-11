using System;

namespace StrategyPatternWithContext
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pofur is hungry, he demands food!");
            var context = new StrategyContext();
            var nutritionStrategy = context.GetStrategy(DateTime.Now.Hour);
            context.ApplyStrategy(nutritionStrategy);
            Console.ReadKey();
        }
    }
}
