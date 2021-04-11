using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisitorPattern.Visitors;

namespace VisitorPattern
{
    public interface ICat
    {
        void AcceptVisitor(IVisitor visitor);
    }
}
