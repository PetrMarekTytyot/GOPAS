using Calculator.Models;
using Calculator.Views;
using Ninject;

namespace Calculator.Controllers
{
    public class MainController : ControllerBase, IMainController
    {

        public IView ErrorView { get; set; }

        public MainController(IKernel container) : base(container)
        {
        }

        public string ErrorMessage { get; private set; }

        private void clacAction(string input, Action<double> op) {
            try
            {
                var x = Double.Parse(input);
                op(x);
                MainView.UpdateView();
                ErrorMessage = "";
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
                ErrorView = container.Get<IView>("Error");
                ((Form)ErrorView).Show();
                ErrorView.UpdateView();
            }
        }

        public void PlusAction(string input) =>
            clacAction(input, model.Plus);

        public void MinusAction(string input) =>
            clacAction(input, model.Minus);

        public void ExitAppAction()
        {
            Application.Exit();
        }

        public void CloseErrrorAction()
        {
            ((Form)ErrorView).Close();
        }
    }
}
