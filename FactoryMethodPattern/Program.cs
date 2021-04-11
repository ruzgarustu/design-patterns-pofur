using System;

namespace FactoryMethodPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // GetFood is the publicly exposed method of the abstract FoodFactory class.
            // Its abstract method ArrangeFoodForCat is implemented by the specific factory classes that derive from FoodFactory.(WetFoodFactory and SnackFoodFactory)
            // These sub-factory classes simply decide what class to instantiate through this implemented method.
            var food = new WetFoodFactory().GetFood();
            Console.WriteLine($"Pofur is about to eat {food.GetAmountAsGram()} grams of {food.GetFoodType()}");

            food = new SnackFactory().GetFood();
            Console.WriteLine($"Pofur is about to eat {food.GetAmountAsGram()} grams of {food.GetFoodType()}");
        }
    }
}
