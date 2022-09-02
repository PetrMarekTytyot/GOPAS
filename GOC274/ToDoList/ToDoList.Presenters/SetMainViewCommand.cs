namespace ToDoList.Presenters
{
    public class SetMainViewCommand : PresenterCommandBase
    {
        public SetMainViewCommand(IMainPresenter reciever, IView<MainViewData> mainView) : base(reciever)
        {
            MainView = mainView;
        }

        public IView<MainViewData> MainView { get; set; }

        public override void Execute()
        {
            reciever.MainView = MainView;
        }
    }
}