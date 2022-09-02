using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyAndDecoratorDemo
{
    public class CalcClient
    {
        private ICalc calc;

        public CalcClient(ICalc calc)
        {
            this.calc = calc;
        }

        public double HalfPlusHalf()
        {
            return calc.Plus(.5, .5);
        }
    }
}
