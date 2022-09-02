using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Models
{
    public class ToDoService : IToDoService
    {
        public ToDo Delete(Guid id, IList<ToDo> list)
        {
            var existing = list.First(t => t.Id == id);
            list.Remove(existing);
            return new ToDo()
            {
                Done = existing.Done,
                Id = id,
                Text = existing.Text
            };
        }

        public SaveResult Save(ToDo todo, IList<ToDo> list)
        {
            var existing = list.FirstOrDefault(t => t.Id == todo.Id);
            if(existing != null)
            {
                var result = new SaveResult()
                {
                    Updated = true,
                    OriginalState = new ToDo()
                    {
                        Id = existing.Id,
                        Done = existing.Done,
                        Text = existing.Text
                    }
                };
                existing.Text = todo.Text;
                existing.Done = todo.Done;
                return result;
            }
            else
            {
                list.Add(todo);
                return new SaveResult();
            }
        }
    }
}
