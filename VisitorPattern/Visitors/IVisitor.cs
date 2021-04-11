using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern.Visitors
{
    public interface IVisitor
    {
        void Visit(ICat cat);
    }
}
