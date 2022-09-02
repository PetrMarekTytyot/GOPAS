namespace ToDoList.Models
{
    public interface IModelFacade
    {
        IEnumerable<ToDo> List { get; }

        ToDo DeleteToDo(Guid id);
        SaveResult SaveToDo(ToDo todo);
    }
}