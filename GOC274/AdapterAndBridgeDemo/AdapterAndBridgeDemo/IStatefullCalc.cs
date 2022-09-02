namespace AdapterAndBridgeDemo
{
    public interface IStatefullCalc
    {
        int Result { get; }

        int Plus(int x);
    }
}