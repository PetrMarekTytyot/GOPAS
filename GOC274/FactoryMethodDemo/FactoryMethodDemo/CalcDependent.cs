namespace FactoryMethodDemo
{
    public class CalcDependent
    {
        protected virtual Calc CreateCalc()
        {
            return new Calc();
        }
        public double OnePlusOne()
        {
            var calc = CreateCalc();
            calc.Plus(1);
            calc.Plus(1);
            return calc.Result;
        }
    }
}
