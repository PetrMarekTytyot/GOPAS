using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyAndDecoratorDemo
{
    public class RoundingProxy : ICalc
    {
        private ICalc calc;

        public RoundingProxy(ICalc calc)
        {
            this.calc = calc;
        }

        public double Plus(double x, double y)
        {
            return calc.Plus(Math.Round(x), Math.Round(y));
        }
    }
}
