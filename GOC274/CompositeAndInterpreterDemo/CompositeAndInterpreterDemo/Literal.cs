using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeAndInterpreterDemo
{
    public class Literal : IExpression
    {
        private int value;

        public Literal(int value)
        {
            this.value = value;
        }

        public int Interpret(IDictionary<string, int> context)
        {
            return value;
        }
    }
}
