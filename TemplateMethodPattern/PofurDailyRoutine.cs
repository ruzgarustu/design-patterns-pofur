using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodPattern
{
    public abstract class PofurDailyRoutine
    {
        public void ProceedDailyRoutine()
        {
            EatFood();
            Play();
            Sleep();
            GoToToilet();
        }

        protected abstract void Play();
        protected abstract void Sleep();

        protected void EatFood()
        {
            Console.WriteLine("Pofur is eating his food!");
        }

        private void GoToToilet()
        {
            Console.WriteLine("Pofur is in toilet, run away for your life!");
        }
    }
}
