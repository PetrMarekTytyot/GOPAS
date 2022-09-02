namespace MediatorDemo
{
    public class Mediator
    {
        public Calc Calc { get; set; }
        public Log Logger { get; set; }

        internal void Log(string message)
        {
            Logger.Write(message);
        }

        internal double Plus(double x, double y, bool log)
        {
            return Calc.Plus(x, y, log);
        }
    }
}