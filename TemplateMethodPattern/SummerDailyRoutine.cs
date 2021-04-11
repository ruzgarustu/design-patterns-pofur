using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public class SummerDailyRoutine : PofurDailyRoutine
    {
        protected override void Play()
        {
            Console.WriteLine("Pofur is playing with flies and butterflies!");
        }

        protected override void Sleep()
        {
            Console.WriteLine("Pofur is sleeping in his hammock in balcony!");
        }
    }
}
