using System;

namespace SingletonPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Pofur is a long haired cat in need of cat grass regularly .That is why we try to keep cat grass at home all the time, and if there is not any, we buy one as soon as possible.
            // If he wants to eat some grass and if there is not any at home, we will buy one for him in a nanosecond and he will be eating that grass.
            // If he wants to it again some hours later, he will be eating the same grass because there is already an instance of it at home and we do not buy another until the one at home goes bad.
            // When he is eating the grass, he will put a lock on this so that other hypothetical cats (threads) can not eat with him at the same time.
            // Notice how the CatGrass class is sealed, that is because we do not want to derive any other classes from it.
            // Notice that the constructor is private, we want to take care of single object creation logic inside this class and do not want client to create it.

            var grass1 = CatGrass.GetCatGrass();
            var grass2 = CatGrass.GetCatGrass();

            if (grass1 == grass2)
            {
                Console.WriteLine("It is the same grass!");
            }
        }
    }
}
