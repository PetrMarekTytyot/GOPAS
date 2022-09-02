namespace ToDoList.Presenters
{
    internal class SetDetailViewCommand : PresenterCommandBase
    {
        public SetDetailViewCommand(IMainPresenter reciever, IView<DetailViewData> detailView): base(reciever)
        {
            DetailView = detailView;
        }

        public IView<DetailViewData> DetailView { get; set; }

        public override void Execute()
        {
            reciever.DetailView = DetailView;
        }
    }
}