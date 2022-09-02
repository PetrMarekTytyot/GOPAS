namespace ToDoList.Models
{
    public class ToDo
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Text { get; set; }
        public bool Done { get; set; }

        public override string ToString() => $"{Text} ({Done})";
    }
}