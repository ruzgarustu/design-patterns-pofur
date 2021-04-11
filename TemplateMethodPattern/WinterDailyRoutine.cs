using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public class WinterDailyRoutine : PofurDailyRoutine
    {
        protected override void Play()
        {
            Console.WriteLine("Pofur is playing with snowflakes!");
        }

        protected override void Sleep()
        {
            Console.WriteLine("Pofur is sleeping on his mom's lap!");
        }
    }
}
