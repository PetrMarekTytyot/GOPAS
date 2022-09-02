using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class ModelFacade : IModelFacade
    {
        private IList<ToDo> list = new List<ToDo>();
        private IToDoService todoService;

        public ModelFacade(IToDoService todoService)
        {
            this.todoService = todoService;
        }

        public IEnumerable<ToDo> List => list;

        public void SaveToDo(ToDo todo)
        {
            todoService.Save(todo, list);
        }

        public void DeleteToDo(Guid id)
        {
            todoService.Delete(id, list);
        }
    }
}
