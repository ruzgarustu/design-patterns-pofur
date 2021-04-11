﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public abstract class FoodFactory
    {
        public ICatFood GetFood()
        {
            return this.ArrangeFoodForCat();
        }

        protected abstract ICatFood ArrangeFoodForCat();
    }
}
