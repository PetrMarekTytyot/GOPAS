namespace FactoryMethodDemo
{
    public class NewCalc : Calc
    {
        public override void Plus(double x)
        {
            base.Plus(x*.9);
        }
    }
}
