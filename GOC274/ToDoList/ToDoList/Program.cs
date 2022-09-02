using Ninject;
using ToDoList.Models;
using ToDoList.Presenters;
using ToDoList.Views;

namespace ToDoList
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var container = new ToDoContainter();
            Application.Run((Form)container.Get<IView<MainViewData>>());
        }
    }
}