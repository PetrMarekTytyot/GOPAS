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
using System.Windows.Shapes;
using ToDoList.Presenters;

namespace ToDoList.Wpf
{
    /// <summary>
    /// Interaction logic for DetailWindow.xaml
    /// </summary>
    public partial class DetailWindow : Window, IView<DetailViewData>
    {
        public DetailWindow()
        {
            InitializeComponent();
        }

        public void UpdateView(DetailViewData viewData)
        {
            //throw new NotImplementedException();
        }
    }
}
