using Calculator.Controllers;
using Calculator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.Views
{
    public partial class LogInForm : Form, IView
    {
        private IModelFacade model;
        private ILoginController controller;
        private ICommandProcessor cmdProc;
        public LogInForm(IModelFacade model, ILoginController controller, ICommandProcessor cmdProc)
        {
            InitializeComponent();
            this.model = model;
            this.controller = controller;
            //this.controller.LogInView = this;
            cmdProc.Execute(
                new SetLoginViewCommand((LoginController)controller) { 
                    LoginView = this 
                }
            );
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            controller.LogInAction(userTextBox.Text, passwordTextBox.Text);
        }

        public void UpdateView()
        {
            errorLabel.Visible = !controller.LoggedIn;
        }
    }
}
