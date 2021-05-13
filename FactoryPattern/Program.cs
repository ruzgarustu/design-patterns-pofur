using System;

namespace FactoryPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Pofur is hungry!");

            // Assume we give different kinds of food to Pofur based on the time of the day.
            // FoodFactory class holds this logic so we do not need to know the implementation details on client.
            var food = FoodFactory.GetFoodForCat(DateTime.Now);
            Console.WriteLine($"Pofur is about to eat {food.GetAmountAsGram()} grams of {food.GetFoodType()}!");
        }
    }
}
