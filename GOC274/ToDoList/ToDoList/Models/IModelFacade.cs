namespace ToDoList.Models
{
    public interface IModelFacade
    {
        IEnumerable<ToDo> List { get; }

        void DeleteToDo(Guid id);
        void SaveToDo(ToDo todo);
    }
}