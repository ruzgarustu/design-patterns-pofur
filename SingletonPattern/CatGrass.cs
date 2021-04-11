using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class CatGrass
    {
        private static CatGrass grass;
        private static Object syncLock = new Object();

        private CatGrass()
        {
        }

        public static CatGrass GetCatGrass()
        {
            lock (syncLock)
            {
                if (grass == null)
                {
                    grass = new CatGrass();
                }
            }

            return grass;
        }

    }
}
