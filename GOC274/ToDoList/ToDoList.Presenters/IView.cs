namespace ToDoList.Presenters
{
    public interface IView { }
    public interface IView<T> : IView
    {
        void UpdateView(T viewData);
    }
}