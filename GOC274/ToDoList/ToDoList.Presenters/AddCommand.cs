namespace ToDoList.Presenters
{
    public class AddCommand : PresenterCommandBase
    {
        public AddCommand(IMainPresenter reciever) : base(reciever)
        {
        }

        public override void Execute()
        {
            reciever.AddAction();
        }
    }
}