using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Presenters
{
    public interface ICommandProcessor
    {
        void Execute(ICommand cmd);
        void Undo();
    }
}
