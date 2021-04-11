using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Visitors;

namespace VisitorPattern
{
    public class Cat : ICat
    {
        public string Nickname { get; set; }

        public Cat(string nickname)
        {
            Nickname = nickname;
        }
        public void AcceptVisitor(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
