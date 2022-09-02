namespace ToDoList.Models
{
    public class SaveResult
    {
        public bool Updated { get;  set; }
        public ToDo OriginalState { get;  set; }
    }
}