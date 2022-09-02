using Calculator.Controllers;
using Calculator.Models;
using Calculator.Views;
using Ninject;

namespace Calculator
{
    public class CalcContainer : StandardKernel
    {
        public CalcContainer()
        {
            Bind<ICalc>().To<Calc>().InSingletonScope();
            Bind<ILogger>().To<Logger>().InSingletonScope();
            Bind<IAuth>().To<Auth>().InSingletonScope();
            Bind<IModelFacade>().To<ModelFacade>().InSingletonScope();

            //Bind<IReadOnlyCalc>().ToConstant(this.Get<ICalc>());

            Bind<ICommandProcessor>().To<CommandProcessor>().InSingletonScope();
            Bind<IMainController>().To<MainController>().InSingletonScope();
            Bind<ILoginController>().To<LoginController>().InSingletonScope();

            Bind<IView>().To<LogInForm>().Named("Login");
            Bind<IView>().To<MainForm>().Named("Main");
            Bind<IView>().To<ErrorForm>().Named("Error");


        }
    }
}
