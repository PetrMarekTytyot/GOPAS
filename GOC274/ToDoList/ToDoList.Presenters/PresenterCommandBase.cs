namespace ToDoList.Presenters
{
    public abstract class PresenterCommandBase : ICommand
    {
        protected IMainPresenter reciever;

        protected PresenterCommandBase(IMainPresenter reciever)
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
