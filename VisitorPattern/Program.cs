using System;
using VisitorPattern.Visitors;

namespace VisitorPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Assume we have a local shelter that keeps track of the cats (AnimalShelter class)
            // And there is a volunteer vet, a barber and a playmate that come to visit the cats daily, contributing to their physical and mental well-being.
            var localShelter = new AnimalShelter();

            Console.WriteLine("Today's visit logs are as follows:");

            // Vet visits the cats at around 8 o'clock every day
            var vet = new Vet();
            localShelter.AllowVisitorToShelter(vet);

            // Afternoons comes the barber
            var barber = new Barber();
            localShelter.AllowVisitorToShelter(barber);

            // Cats start to be active in the evening, playmate comes to play with them
            var playmate = new Playmate();
            localShelter.AllowVisitorToShelter(playmate);

        }
    }
}
