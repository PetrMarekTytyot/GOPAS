using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class ToDoService : IToDoService
    {
        public void Delete(Guid id, IList<ToDo> list)
        {
            list.Remove(list.First(t => t.Id == id));
        }

        public void Save(ToDo todo, IList<ToDo> list)
        {
            var existing = list.FirstOrDefault(t => t.Id == todo.Id);
            if(existing != null)
            {
                existing.Text = todo.Text;
                existing.Done = todo.Done;
            }
            else
            {
                list.Add(todo);
            }
        }
    }
}
