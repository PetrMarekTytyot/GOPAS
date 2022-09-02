using Ninject;
using ToDoList.Models;
using ToDoList.Presenters;
using ToDoList.Views;

namespace ToDoList
{
    public class ToDoContainter: StandardKernel
    {
        public ToDoContainter()
        {
            Bind<IToDoService>().To<ToDoService>();
            Bind<IModelFacade>().To<ModelFacade>().InSingletonScope();

            Bind<ICommandFactory>().To<CommandFactory>();
            Bind<ICommandProcessor>().To<CommandProcessor>().InSingletonScope();
            Bind<IMainPresenter>().To<MainPresenter>().InSingletonScope();

            Bind<IViewHandler>().To<WinFormsViewHandler>();
            Bind<IView<MainViewData>>().To<MainForm>();
            Bind<IView<DetailViewData>>().To<DetailForm>();
        }
    }
}
