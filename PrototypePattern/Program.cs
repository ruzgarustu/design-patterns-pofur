using System;

namespace PrototypePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Assume we have a little cat pension that can accommodate up to 5 cats at a time and we need to keep track of their records.
            // We have a prototype called GuestCat, and with help of deep cloning we can create guest cat instances and initialize them with their own (value type or reference type) info in client.

            GuestCat guest1 = new GuestCat()
            {
                Name = "Pofi",
                DaysOfStay = 5,
                Age = 4,
                SpecificDiet = new DietNeeds() { RawMeatDiet = true, SeniorCareDiet = false, UrinaryCareDiet = false }
            };

            GuestCat guest2 = (GuestCat)guest1.Clone();
            guest2.Name = "Topi";
            guest2.Age = 15;
            guest2.DaysOfStay = 7;
            guest2.SpecificDiet = new DietNeeds() { RawMeatDiet = false, SeniorCareDiet = true, UrinaryCareDiet = true };

            Console.WriteLine("Original guest: ");
            Console.WriteLine($"Name: {guest1.Name} --- Age: {guest1.Age} --- Days of stay: {guest1.DaysOfStay} --- Specific Diet: " +
                $"RawMeat? {guest1.SpecificDiet.RawMeatDiet} " + $"SeniorCare? {guest1.SpecificDiet.SeniorCareDiet} " + $"UninaryCare? {guest1.SpecificDiet.UrinaryCareDiet} ");

            Console.WriteLine("Cloned guest: ");
            Console.WriteLine($"Name: {guest2.Name} --- Age: {guest2.Age} --- Days of stay: {guest2.DaysOfStay} --- Specific Diet: " +
                $"RawMeat? {guest2.SpecificDiet.RawMeatDiet} " + $"SeniorCare? {guest2.SpecificDiet.SeniorCareDiet} " + $"UninaryCare? {guest2.SpecificDiet.UrinaryCareDiet} ");

        } 
    }
}
