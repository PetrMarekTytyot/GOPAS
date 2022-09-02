namespace Calculator.Models
{
    public interface IReadOnlyCalc
    {
        double Result { get; }
    }

    public interface ICalc: IReadOnlyCalc
    {
        void Plus(double input);
        void Minus(double x);
    }
}