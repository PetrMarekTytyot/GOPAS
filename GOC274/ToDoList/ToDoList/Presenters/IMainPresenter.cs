using ToDoList.Models;

namespace ToDoList.Presenters
{
    public interface IMainPresenter
    {
        IView<DetailViewData> DetailView { get; set; }
        IView<MainViewData> MainView { get; set; }

        void AddAction();
        void EditAction(ToDo toDo);
        void SaveAction(ToDo toDo);
        void DeleteAction(Guid id);
    }
}