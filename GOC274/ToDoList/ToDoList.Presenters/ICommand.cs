namespace ToDoList.Presenters
{
    public interface ICommand
    {
        bool IsCompensable { get; }

        void Execute();
        void Compensate();
    }
}