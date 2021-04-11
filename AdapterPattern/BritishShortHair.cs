using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class BritishShortHair : IBarberCat
    {
        public void CombFur()
        {
            Console.WriteLine($"{nameof(BritishShortHair)} fur care completed by combing fur!");
        }
    }
}
