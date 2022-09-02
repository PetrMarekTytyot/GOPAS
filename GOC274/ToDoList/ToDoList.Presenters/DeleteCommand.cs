using ToDoList.Models;

namespace ToDoList.Presenters
{
    public class DeleteCommand : PresenterCommandBase
    {
        private ToDo deleted;
        public DeleteCommand(IMainPresenter reciever, Guid id) : base(reciever)
        {
            Id = id;
        }

        public Guid Id { get; set; }

        public override void Execute()
        {
            deleted = reciever.DeleteAction(Id);
        }

        public override bool IsCompensable => true;

        public override void Compensate()
        {
            reciever.SaveAction(deleted);
        }


    }
}