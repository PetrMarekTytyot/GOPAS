using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ToDoList.Presenters;

namespace ToDoList.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, IView<MainViewData>
    {
        private IMainPresenter presenter;
        public MainWindow(IMainPresenter presenter)
        {
            InitializeComponent();
            this.presenter = presenter;
            this.presenter.MainView = this;
        }

        public void UpdateView(MainViewData viewData)
        {
            //throw new NotImplementedException();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            presenter.AddAction();
        }
    }
}
