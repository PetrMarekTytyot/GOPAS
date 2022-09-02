using ToDoList.Models;

namespace ToDoList.Presenters
{
    public class MainViewData
    {
        public IEnumerable<ToDo> Todos { get; set; }
        public Color BgColor { get; set; }
    }
}