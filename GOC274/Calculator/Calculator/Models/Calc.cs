namespace Calculator.Models
{
    public class Calc : ICalc
    {
        public double Result { get; private set; }

        public void Minus(double input)
        {
            Result -= input;
        }

        public void Plus(double input)
        {
            Result += input;
        }
    }
}
