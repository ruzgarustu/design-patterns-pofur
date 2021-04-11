using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.Visitors
{
    public class Playmate : IVisitor
    {
        public void Visit(ICat cat)
        {
            var visitedCat = (Cat)cat;
            Console.WriteLine($"Playmate visited the cat {visitedCat.Nickname} and played with him.");
        }
    }
}
