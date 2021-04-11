using System;
using System.Collections.Generic;
using System.Text;

namespace ProxyPattern
{
    public class UnderAgedOwner : ICatOwner
    {
        private AdultOwner _owner = new AdultOwner();
        
        public void PlayWithCat()
        {
            Console.WriteLine("Child played with the cat.");
        }

        public void TakeCatToBarber()
        {
            _owner.TakeCatToBarber();
        }

        public void InsureCat()
        {
            _owner.InsureCat();
        }

    }
}
