using AdapterPattern;
using System;
using System.Collections.Generic;

namespace Adapter
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Assume you are a cat barber in a sub-tropical region and until now you have only taken care of short-haired cats.
            // You have a service named "comb fur" and it is standard for short-haired cats, namely combing fur.
            // Now you have a new customer that is a long-haired Norwegian cat, and combing fur has a new definiton for this cat: You need to trim his popo, remove the knots and clean its undercoat.
            // Here you need an adaptor class where you can redefine those necessary tasks under the service name of "comb fur".
            var catsWaitingInLine = new List<IBarberCat>();

            catsWaitingInLine.Add(new Egyptian());
            catsWaitingInLine.Add(new BritishShortHair());
            catsWaitingInLine.Add(new NorwegianForestAdapter(new NorwegianForest()));

            foreach (var cat in catsWaitingInLine)
            {
                cat.CombFur();
            }

            Console.ReadLine();
        }
    }
}
