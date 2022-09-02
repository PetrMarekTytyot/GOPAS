namespace Calculator.Models
{
    public interface IModelFacade
    {
        double Result { get; }
        void Plus(double x);
        void Minus(double x);

        bool LogIn(string user, string pwd);
    }
}