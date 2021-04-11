using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    public class DietNeeds : ICloneable
    {
        public bool UrinaryCareDiet  { get; set; }
        public bool SeniorCareDiet { get; set; }
        public bool RawMeatDiet { get; set; }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
