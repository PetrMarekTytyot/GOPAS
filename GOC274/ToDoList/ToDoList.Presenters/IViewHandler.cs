namespace ToDoList.Presenters
{
    public interface IViewHandler
    {
        bool IsUsable(IView view);
        void Display(IView view);
        void Hide(IView view);
    }
}