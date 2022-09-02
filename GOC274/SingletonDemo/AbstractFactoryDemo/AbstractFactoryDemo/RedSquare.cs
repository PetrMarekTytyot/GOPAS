using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    public class RedSquare : ISquare
    {
        public void DoSomethingWithSquare()
        {
            Console.WriteLine("Red square");
        }
    }
}
