using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class NorwegianForest
    {
        public void TrimPopo()
        {
            Console.WriteLine("Trimmed popo!");
        }

        public void RemoveKnots()
        {
            Console.WriteLine("Got rid of all knots!");
        }

        public void CleanUndercoat()
        {
            Console.WriteLine("Undercoat cleaned!");
        }
    }
}
