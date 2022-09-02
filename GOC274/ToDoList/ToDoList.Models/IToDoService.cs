namespace ToDoList.Models
{
    public interface IToDoService
    {
        SaveResult Save(ToDo todo, IList<ToDo> list);
        ToDo Delete(Guid id, IList<ToDo> list);
    }
}