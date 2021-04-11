using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.Visitors
{
    public class Vet : IVisitor
    {
        public void Visit(ICat cat)
        {
            var visitedCat = (Cat)cat;
            Console.WriteLine($"Vet visited the cat {visitedCat.Nickname} and checked his health.");
        }
    }
}
