using ToDoList.Models;
using ToDoList.Presenters;

namespace ToDoList.Views
{
    public partial class MainForm : Form, IView<MainViewData>
    {
        //private IMainPresenter presenter;
        private ICommandProcessor commandProcessor;
        private ICommandFactory commandFactory;
        public MainForm(ICommandProcessor commandProcessor, ICommandFactory commandFactory)
        {
            InitializeComponent();
            //this.presenter = presenter;
            //this.presenter.MainView = this;
            this.commandProcessor = commandProcessor;
            this.commandFactory = commandFactory;
            commandProcessor.Execute(
                commandFactory.CreateSetMainViewCommand(this)
            );
        }

        private IEnumerable<ToDo> todos;

        public void UpdateView(MainViewData viewData)
        {
            listBox.DataSource = null;
            listBox.DataSource = viewData.Todos;
            BackColor = viewData.BgColor;
            todos = viewData.Todos;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            //presenter.AddAction();
            commandProcessor.Execute(
                commandFactory.CreateAddCommand()
            );
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            // presenter.EditAction((ToDo)listBox.SelectedItem);
            commandProcessor.Execute(
                commandFactory.CreateEditCommand(
                    (ToDo)listBox.SelectedItem
                )
            );
            
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //presenter.DeleteAction(((ToDo)listBox.SelectedItem).Id);
            commandProcessor.Execute(
                commandFactory.CreateDeleteCommand(
                    ((ToDo)listBox.SelectedItem).Id
                )
            );
        }

        private void badButton_Click(object sender, EventArgs e)
        {
            ((List<ToDo>)todos).Clear();
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            commandProcessor.Undo();
        }
    }
}
