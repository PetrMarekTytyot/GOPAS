using Ninject;
using ToDoList.Models;
using ToDoList.Presenters;

namespace ToDoList.Wpf
{
    public class ToDoContainter: StandardKernel
    {
        public ToDoContainter()
        {
            Bind<IToDoService>().To<ToDoService>();
            Bind<IModelFacade>().To<ModelFacade>().InSingletonScope();

            Bind<IMainPresenter>().To<MainPresenter>().InSingletonScope();

            Bind<IViewHandler>().To<WpfViewHandler>();
            Bind<IView<MainViewData>>().To<MainWindow>();
            Bind<IView<DetailViewData>>().To<DetailWindow>();
        }
    }
}
