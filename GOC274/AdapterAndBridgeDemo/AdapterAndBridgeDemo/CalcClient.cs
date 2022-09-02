namespace AdapterAndBridgeDemo
{
    public class CalcClient
    {
        private IStatelessCalc calc;

        public CalcClient(IStatelessCalc calc)
        {
            this.calc = calc;
        }

        public int OnePlusOne() => calc.Sum(1, 1);
        
    }
}
