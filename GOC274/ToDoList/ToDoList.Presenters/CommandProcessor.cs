namespace ToDoList.Presenters
{
    public class CommandProcessor : ICommandProcessor
    {
        private readonly Stack<ICommand> cmdStack = new Stack<ICommand>();
        public void Execute(ICommand command)
        {
            command.Execute();
            if (command.IsCompensable) cmdStack.Push(command);
        }

        public void Undo()
        {
            if(cmdStack.Count > 0)
                cmdStack.Pop().Compensate();
        }
    }
}
