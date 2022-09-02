using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDemo
{
    internal class CommandProcessor
    {
        private Stack<ICommand> cmdStack = new Stack<ICommand>();
        public void ExecuteCommand(ICommand cmd)
        {
            cmd.Execute();
            if (cmd.IsCompensable) cmdStack.Push(cmd);
        }

        public void CompensateLastCommand()
        {
            if(cmdStack.Count > 0)
                cmdStack.Pop().Compensate();
        }
    }
}
