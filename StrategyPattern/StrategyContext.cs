using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternWithContext
{
    public class StrategyContext
    {
        Dictionary<string, INutritionStrategy> context = new Dictionary<string, INutritionStrategy>();

        public StrategyContext()
        {
            context.Add(nameof(DryFoodStrategy), new DryFoodStrategy());
            context.Add(nameof(WetFoodStrategy), new WetFoodStrategy());
            context.Add(nameof(SnackStrategy), new SnackStrategy());
        }

        public INutritionStrategy GetStrategy(int hour)
        {
            return hour switch
            {
                <= 14 => context[nameof(DryFoodStrategy)],
                >= 18 => context[nameof(WetFoodStrategy)],
                _ => context[nameof(SnackStrategy)],
            };
        }

        public void ApplyStrategy(INutritionStrategy nutritionStrategy)
        {
            (string brand, int quantity) catFood = nutritionStrategy.FeedTheCat();
            Console.WriteLine($"{catFood.quantity} grams of {catFood.brand} to the rescue.");
        }

    }
}
