namespace FactoryMethodDemo
{
    public class Calc
    {
        public double Result { get; private set; }
        public virtual void Plus(double x) => Result += x;
    }
}
