using Calculator.Controllers;
using Calculator.Models;

namespace Calculator.Views
{
    public partial class MainForm : Form, IView
    {
        IMainController controller;
        IModelFacade model;
        ICommandProcessor commandProcessor;
        public MainForm(IModelFacade model, IMainController controller, ICommandProcessor commandProcessor)
        {
            InitializeComponent();
            this.model = model;
            this.controller = controller;
            this.controller.MainView = this;
            this.commandProcessor = commandProcessor;
        }

        public void UpdateView()
        {
            resultLabel.Text = model.Result.ToString();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            //controller.PlusAction(inputTextBox.Text);
            commandProcessor.Execute(new PlusCommand((MainController)controller)
            {
                Input = inputTextBox.Text
            });
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            controller.MinusAction(inputTextBox.Text);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            controller.ExitAppAction();
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            commandProcessor.Undo();
        }
    }
}
