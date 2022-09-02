using ToDoList.Models;

namespace ToDoList.Presenters
{
    public interface IMainPresenter
    {
        IView<DetailViewData> DetailView { get; set; }
        IView<MainViewData> MainView { get; set; }

        void AddAction();
        void EditAction(ToDo toDo);
        SaveResult SaveAction(ToDo toDo);
        ToDo DeleteAction(Guid id);
    }
}