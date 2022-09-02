using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoList.Presenters;

namespace ToDoList.Views
{
    public class WinFormsViewHandler : IViewHandler
    {
        public void Display(IView view) => ((Form)view).Show();

        public void Hide(IView view) => ((Form)view).Hide();

        public bool IsUsable(IView view) =>
            view != null && !((Form)view).IsDisposed;
    }
}
