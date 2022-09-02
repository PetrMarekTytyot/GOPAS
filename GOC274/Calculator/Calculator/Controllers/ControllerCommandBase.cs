namespace Calculator.Controllers
{
    public abstract class ControllerCommandBase<T> : ICommand
        where T : ControllerBase
    {
        protected readonly T reciever;

        protected ControllerCommandBase(T reciever)
        {
            this.reciever = reciever;
        }

        public virtual bool IsCompensable => false;

        public virtual void Compensate()
        {
            throw new NotImplementedException();
        }

        public abstract void Execute();
    }
}
