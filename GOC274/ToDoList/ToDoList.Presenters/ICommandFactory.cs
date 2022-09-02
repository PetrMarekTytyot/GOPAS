using ToDoList.Models;

namespace ToDoList.Presenters
{
    public interface ICommandFactory
    {
        ICommand CreateSetMainViewCommand(IView<MainViewData> mainView);
        ICommand CreateAddCommand();
        ICommand CreateEditCommand(ToDo todo);
        ICommand CreateDeleteCommand(Guid id);
        ICommand CreateSetDetailViewCommand(IView<DetailViewData> detailView);
        ICommand CreateSaveCommand(ToDo toDo);
    }
}
