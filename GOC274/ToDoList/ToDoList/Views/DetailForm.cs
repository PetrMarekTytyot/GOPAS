using ToDoList.Models;
using ToDoList.Presenters;

namespace ToDoList.Views
{
    public partial class DetailForm : Form, IView<DetailViewData>
    {
        //private IMainPresenter presenter;
        private ICommandProcessor commandProcessor;
        private ICommandFactory commandFactory;
        private Guid id;
        public DetailForm(ICommandProcessor commandProcessor, ICommandFactory commandFactory)
        {
            InitializeComponent();
            //this.presenter = presenter;
            //this.presenter.DetailView = this;
            this.commandProcessor = commandProcessor;
            this.commandFactory = commandFactory;
            commandProcessor.Execute(
                commandFactory.CreateSetDetailViewCommand(this)
            );
        }

        public void UpdateView(DetailViewData viewData)
        {
            id = viewData.ToDo.Id;
            textTextBox.Text = viewData.ToDo.Text;
            doneCheckBox.Checked = viewData.ToDo.Done;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //presenter.SaveAction(new ToDo()
            //{
            //    Id = id,
            //    Text = textTextBox.Text,
            //    Done = doneCheckBox.Checked
            //});
            commandProcessor.Execute(
                commandFactory.CreateSaveCommand(new ToDo() {
                    Id = id,
                    Text = textTextBox.Text,
                    Done = doneCheckBox.Checked
                })
            );
        }
    }
}
