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
            Bind<IModelFacade>().To<ModelFacade>().InSingletonScope();

            Bind<IReadOnlyCalc>().ToConstant(this.Get<ICalc>());
            
            Bind<IMainController>().To<MainController>().InSingletonScope();

            
        }
    }
}
