using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositeAndInterpreterDemo
{
    public class Variable : IExpression
    {
        private string name;

        public Variable(string name)
        {
            this.name = name;
        }

        public int Interpret(IDictionary<string, int> context)
        {
            return context[name];
        }
    }
}
