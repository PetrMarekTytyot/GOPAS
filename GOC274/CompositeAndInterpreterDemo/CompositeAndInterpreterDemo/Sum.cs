namespace CompositeAndInterpreterDemo
{
    public class Sum : BinaryOperation
    {
        public Sum(IExpression left, IExpression right) : base(left, right)
        {
        }

        public override int Interpret(IDictionary<string, int> context)
        {
            return left.Interpret(context) + right.Interpret(context);
        }
    }
}
