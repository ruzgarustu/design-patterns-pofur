using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class AdultOwner : ICatOwner
    {
        public void PlayWithCat()
        {
            Console.WriteLine("Adult played with the cat.");
        }

        public void TakeCatToBarber()
        {
            Console.WriteLine("Adult took cat to the barber.");
        }

        public void InsureCat()
        {
            Console.WriteLine("Adult insured the cat.");
        }
    }
}
