using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    public class Egyptian: IBarberCat
    {
        public void CombFur()
        {
            Console.WriteLine($"{nameof(Egyptian)} fur care completed by combing fur!");
        }
    }
}
