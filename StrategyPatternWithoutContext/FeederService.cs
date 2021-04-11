using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPatternWithService
{
    public class FeederService
    {
        private IFeedTheCat feedMethod;

        public void SetNutritionMethod(IFeedTheCat strategy)
        {
            feedMethod = strategy;
        }

        public void Feed()
        {
            (string brand, int quantity) catFood = feedMethod.FeedTheCat();
            Console.WriteLine($"{catFood.quantity} grams of {catFood.brand} to the rescue.");
        }

    }
}
