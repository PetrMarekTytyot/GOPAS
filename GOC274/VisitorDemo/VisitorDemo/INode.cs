using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorDemo
{
    public interface INode
    {
        void AcceptVisitor(IVisitor visitor);
    }
}
