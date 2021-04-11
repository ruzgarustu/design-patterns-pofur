using System;

namespace BridgePattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Assume we leave our cat at home during holidays, and our neighbor or cat sitter visits him daily and takes special care of him.
            // With special care, I mean the folowing comments as below:

            // Spring holiday : Cat changes fur so quickly, so cat should be given malt cream by the cat sitter.
            Console.WriteLine("Spring holiday");
            var maltCreamCare = new MaltCreamCare
            {
                _thirdPartyVisit = new CatSitterVisit()
            };
            maltCreamCare.TakeCareOfPofur();



            // Autumn holiday: Cat should be given multivitamin by the neighbor to get ready for the long winter:)
            Console.WriteLine("Autumn holiday");
            var multivitaminCare = new MultivitaminCare
            {
                _thirdPartyVisit = new NeighbourVisit()
            };
            multivitaminCare.TakeCareOfPofur();
        }
    }
}
