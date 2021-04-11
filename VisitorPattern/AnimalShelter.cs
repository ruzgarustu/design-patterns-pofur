using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Visitors;

namespace VisitorPattern
{
    public class AnimalShelter
    {
        private readonly List<ICat> catsInShelter;

        public AnimalShelter()
        {
            catsInShelter = new List<ICat>()
            {
                new Cat("Pofi"),
                new Cat("Topi"),
                new Cat("Belly")
            };
        }

        public void AllowVisitorToShelter(IVisitor visitor)
        {
            foreach (var cat in catsInShelter)
            {
                cat.AcceptVisitor(visitor);
            }

        }
    }
}
