using ToDoList.Models;

namespace ToDoList.Presenters
{
    public class CommandFactory : ICommandFactory
    {
        private readonly IMainPresenter reciever;

        public CommandFactory(IMainPresenter reciever)
        {
            this.reciever = reciever;
        }

        public ICommand CreateAddCommand() => 
            new AddCommand(reciever);

        public ICommand CreateDeleteCommand(Guid id) =>
            new DeleteCommand(reciever, id);

        public ICommand CreateEditCommand(ToDo todo) =>
            new EditCommand(reciever, todo);

        public ICommand CreateSaveCommand(ToDo toDo) =>
            new SaveCommand(reciever, toDo);

        public ICommand CreateSetDetailViewCommand(IView<DetailViewData> detailView) =>
            new SetDetailViewCommand(reciever, detailView);

        public ICommand CreateSetMainViewCommand(IView<MainViewData> mainView) =>
            new SetMainViewCommand(reciever, mainView);
    }
}
