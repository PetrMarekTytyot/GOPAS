using Calculator.Views;
using Ninject;

namespace Calculator
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            //var model = new Calc();
            //var mainController = new MainController(model);
            //var mainView = new MainForm(model, mainController);

            // var factory = new ViewFactory();
            var container = new CalcContainer();

            Application.Run(container.Get<MainForm>());
        }
    }
}