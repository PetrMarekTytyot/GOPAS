namespace CommandDemo
{
    internal interface ICommand
    {
        void Execute();
        bool IsCompensable { get; }
        void Compensate();
    }
}
