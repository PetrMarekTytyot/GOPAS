namespace CompositeAndInterpreterDemo
{
    public abstract class BinaryOperation: IExpression
    {
        protected IExpression left;
        protected IExpression right;

        protected BinaryOperation(IExpression left, IExpression right)
        {
            this.left = left;
            this.right = right;
        }

        public abstract int Interpret(IDictionary<string, int> context);
    }
}
