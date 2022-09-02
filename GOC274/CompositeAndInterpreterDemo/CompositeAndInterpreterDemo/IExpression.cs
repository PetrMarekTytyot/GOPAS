namespace CompositeAndInterpreterDemo
{
    public interface IExpression
    {
        int Interpret(IDictionary<string, int> context);
    }
}
