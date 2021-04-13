using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class GuestCat : ICloneable
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int DaysOfStay { get; set; }
        public DietNeeds SpecificDiet { get; set; } 

        public object Clone()
        {
            GuestCat clonedItem = (GuestCat)this.MemberwiseClone();
            clonedItem.SpecificDiet = (DietNeeds)this.SpecificDiet.Clone();  // necessary for deep copy, if not done it will be a shallow copy and the reference type DietNeeds will not be really cloned.
            return clonedItem;
        }
    }
}
