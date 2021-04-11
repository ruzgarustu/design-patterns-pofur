using System;

namespace ProxyPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Assume there is a 10 year old and a grownup in household who own the cat.
            // The child needs to play with cat, take cat to barber and insure the cat.
            var childOwner = new UnderAgedOwner();

            // Child can play with the cat without any interference from the adult, but can not take the cat to barber or insure the cat herself.
            // For those cases he proxy (UnderAgedOwner) creates a real service object (AdultOwner) and delegates those tasks to it.
            childOwner.PlayWithCat();
            childOwner.TakeCatToBarber();
            childOwner.InsureCat();

            Console.ReadLine();
        }
    }
}
