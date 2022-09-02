namespace AdapterAndBridgeDemo
{
    public class StatefullCalc : IStatefullCalc
    {
        public int Result { get; private set; }
        public int Plus(int x) => Result += x;
    }
}
