using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    public class BlueCircle : ICircle
    {
        public void DoSomethingWithCircle()
        {
            Console.WriteLine("Blue circle");
        }
    }
}
