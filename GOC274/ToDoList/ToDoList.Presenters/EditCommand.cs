using ToDoList.Models;

namespace ToDoList.Presenters
{
    public class EditCommand : PresenterCommandBase
    {
        public EditCommand(IMainPresenter reciever, ToDo todo) : base(reciever)
        {
            ToDo = todo;
        }

        public ToDo ToDo { get; set; }

        public override void Execute()
        {
            reciever.EditAction(ToDo);
        }
    }
}