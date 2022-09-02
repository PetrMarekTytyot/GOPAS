namespace AdapterAndBridgeDemo
{
    public class CalcAdapter : IStatelessCalc
    {
        public int Sum(int v1, int v2)
        {
            IStatefullCalc calc = new StatefullCalc();
            calc.Plus(v1);
            calc.Plus(v2);
            return calc.Result;
        }
    }
}
