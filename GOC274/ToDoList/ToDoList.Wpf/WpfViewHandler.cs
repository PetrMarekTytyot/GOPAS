using System.Windows;
using ToDoList.Presenters;

namespace ToDoList.Wpf
{
    internal class WpfViewHandler : IViewHandler
    {
        public void Display(IView view) => ((Window)view).Show();

        public void Hide(IView view) => ((Window)view).Hide();

        public bool IsUsable(IView view) => view != null;
    }
}