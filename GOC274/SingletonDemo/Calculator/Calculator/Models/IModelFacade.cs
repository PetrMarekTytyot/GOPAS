namespace Calculator.Models
{
    public interface IModelFacade
    {
        double Result { get; }
        void Plus(double x);
    }
}