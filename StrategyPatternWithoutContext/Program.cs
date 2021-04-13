using System;

namespace StrategyPatternWithService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var feederService = new FeederService();

            var feedWithDryFood = new FeedWithDryFood();
            var feedWithWetFood = new FeedWithWetFood();
            var feedWithSnack = new FeedWithSnack();

            Console.WriteLine("Pofur is hungry, he demands food!");

            // The info what to feed Pofur based on the hour of the day is in client.
            // FeederService class is only aware of the IFeedTheCat interface.
            switch (DateTime.Now.Hour)
            {
                case <= 14:
                    feederService.SetNutritionMethod(feedWithDryFood);
                    feederService.Feed();
                    break;
                case >= 18:
                    feederService.SetNutritionMethod(feedWithWetFood);
                    feederService.Feed();
                    break;
                default:
                    feederService.SetNutritionMethod(feedWithSnack);
                    feederService.Feed();
                    break;
            }
            Console.ReadKey();
        }
    }
}
