namespace Calculator.Controllers
{
    public interface ICommandProcessor
    {
        void Execute(ICommand cmd);
        void Undo();
    }
}