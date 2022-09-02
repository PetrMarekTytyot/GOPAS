using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Controllers
{
    internal class CommandProcessor : ICommandProcessor
    {
        private Stack<ICommand> cmdStack = new Stack<ICommand>();
        public void Execute(ICommand cmd)
        {
            cmd.Execute();
            if (cmd.IsCompensable) cmdStack.Push(cmd);
        }
        public void Undo()
        {
            if (cmdStack.Count > 0) cmdStack.Pop().Compensate();
        }
    }
}
