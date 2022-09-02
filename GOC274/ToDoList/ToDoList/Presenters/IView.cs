namespace ToDoList.Presenters
{
    public interface IView<T>
    {
        void UpdateView(T viewData);
    }
}