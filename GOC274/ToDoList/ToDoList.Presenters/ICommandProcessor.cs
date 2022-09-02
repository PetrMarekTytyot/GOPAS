namespace ToDoList.Presenters
{
    public interface ICommandProcessor
    {
        void Execute(ICommand command);
        void Undo();
    }
}
