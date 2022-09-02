using Calculator.Controllers;
using Calculator.Models;

namespace Calculator.Views
{
    public partial class MainForm : Form
    {
        IMainController controller;
        IModelFacade model;
        public MainForm(IModelFacade model, IMainController controller)
        {
            InitializeComponent();
            this.model = model;
            this.controller = controller;
            this.controller.MainView = this;
        }

        public void UpdateView()
        {
            resultLabel.Text = model.Result.ToString();
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            controller.PlusAction(inputTextBox.Text);
        }
    }
}
