namespace MediatorDemo
{
    public class Calc : Colleague
    {
        public Calc(Mediator mediator) : base(mediator)
        {
            mediator.Calc = this;
        }

        public double Plus(double x, double y, bool log)
        {
            var result = x + y;
            if (log) mediator.Log($"LOG: {x}+{y}={result}");
            return result;
        }
    }
}
