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
    public partial class ErrorForm : Form, IView
    {
        IMainController controller;
        IModelFacade model;
        public ErrorForm(IModelFacade model, IMainController controller)
        {
            InitializeComponent();
            this.model = model;
            this.controller = controller;
            this.controller.ErrorView = this;
        }

        public void UpdateView()
        {
            errorLabel.Text = controller.ErrorMessage;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            controller.CloseErrrorAction();
        }
    }
}
