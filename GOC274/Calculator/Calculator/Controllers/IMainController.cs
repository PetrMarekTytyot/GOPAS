using Calculator.Views;

namespace Calculator.Controllers
{
    public interface IMainController
    {
        IView MainView { get; set; }
        IView ErrorView { get; set; }
        string ErrorMessage { get; }

        void PlusAction(string input);
        void MinusAction(string input);
        
        void ExitAppAction();
        void CloseErrrorAction();
    }
}