using Calculator.Models;
using Calculator.Views;

namespace Calculator.Controllers
{
    public class MainController : IMainController
    {
        private IModelFacade model;
        public MainForm MainView { get; set; }

        public MainController(IModelFacade model)
        {
            this.model = model;

        }

        public void PlusAction(string input)
        {
            model.Plus(Double.Parse(input));
            MainView.UpdateView();
        }
    }
}
