using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVVMCalc
{
    public partial class MainForm : Form
    {
        private MainViewModel viewModel;
        public MainForm(ICalc model)
        {
            InitializeComponent();
            viewModel = new MainViewModel(model);
            resultLabel.DataBindings.Add("Text", viewModel, "Result");
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            viewModel.PlusCommand.X = 
                Int32.Parse(inputTextBox.Text);
            viewModel.PlusCommand.Execute();
        }
    }
}
