namespace ToDoList.Models
{
    public interface IToDoService
    {
        void Save(ToDo todo, IList<ToDo> list);
        void Delete(Guid id, IList<ToDo> list);
    }
}