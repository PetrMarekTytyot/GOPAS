using System.Diagnostics;

namespace ProxyAndDecoratorDemo
{
    public class LoggingDecorator : ICalc
    {
        private ICalc calc;

        public LoggingDecorator(ICalc calc)
        {
            this.calc = calc;
        }

        public double Plus(double x, double y)
        {
            var result = calc.Plus(x, y);
            Debug.Print($"LOG: {x}+{y}={result}");
            return result;
        }
    }
}
