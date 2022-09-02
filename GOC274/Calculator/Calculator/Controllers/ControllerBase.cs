using Calculator.Models;
using Ninject;

namespace Calculator.Controllers
{
    public abstract class ControllerBase
    {
        protected IModelFacade model;
        protected IKernel container;

        public IView MainView { get; set; }

        public ControllerBase(IKernel container)
        {
            this.container = container;
            this.model = container.Get<IModelFacade>();

        }
    }
}
