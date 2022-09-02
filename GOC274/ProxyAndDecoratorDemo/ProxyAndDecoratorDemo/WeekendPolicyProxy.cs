using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyAndDecoratorDemo
{
    public class WeekendPolicyProxy : ICalc
    {
        private ICalc calc;

        public WeekendPolicyProxy(ICalc calc)
        {
            this.calc = calc;
        }

        public double Plus(double x, double y)
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday ||
                DateTime.Now.DayOfWeek == DayOfWeek.Sunday)
                throw new Exception("Can't add numbers on weekend");
            return calc.Plus(x, y);
        }
    }
}
