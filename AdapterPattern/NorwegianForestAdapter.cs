using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class NorwegianForestAdapter : IBarberCat
    {
        private NorwegianForest forestCat;
        public NorwegianForestAdapter(NorwegianForest forestCat)
        {
            this.forestCat = forestCat;
        }

        public void CombFur()
        {
            Console.WriteLine("Norwegian fur care in several steps:");
            forestCat.RemoveKnots();
            forestCat.TrimPopo();
            forestCat.CleanUndercoat();
        }
    }
}
