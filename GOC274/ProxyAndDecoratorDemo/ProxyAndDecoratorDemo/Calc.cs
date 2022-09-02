namespace ProxyAndDecoratorDemo
{
    public sealed class Calc : ICalc
    {
        public double Plus(double x, double y) => x + y;
    }
}
