using Calculator.Views;

namespace Calculator.Controllers
{
    public interface IMainController
    {
        MainForm MainView { get; set; }

        void PlusAction(string input);
    }
}