using Ninject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ToDoList.Presenters;

namespace ToDoList.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            var container = new ToDoContainter();
            this.MainWindow = (Window)container.Get<IView<MainViewData>>();
            this.MainWindow.Show();
        }
    }
}
