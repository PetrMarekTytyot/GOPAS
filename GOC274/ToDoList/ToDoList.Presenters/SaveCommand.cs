using ToDoList.Models;

namespace ToDoList.Presenters
{
    internal class SaveCommand : PresenterCommandBase
    {
        private SaveResult result;
        public SaveCommand(IMainPresenter reciever, ToDo toDo) : base(reciever)
        {
            ToDo = toDo;
        }

        public ToDo ToDo { get; set; }

        public override void Execute()
        {
            result = reciever.SaveAction(ToDo);
        }

        public override bool IsCompensable => true;

        public override void Compensate()
        {
            if (result.Updated)
                reciever.SaveAction(result.OriginalState);
            else
                reciever.DeleteAction(ToDo.Id);
        }
    }
}