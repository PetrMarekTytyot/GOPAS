using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeAndInterpreterDemo
{
    public class Product : BinaryOperation
    {
        public Product(IExpression left, IExpression right) : base(left, right)
        {
        }

        public override int Interpret(IDictionary<string, int> context)
        {
            return left.Interpret(context) * right.Interpret(context);
        }
    }
}
