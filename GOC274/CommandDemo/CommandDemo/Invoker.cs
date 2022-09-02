using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDemo
{
    internal class Invoker
    {
        public void ExecuteCommand(ICommand command)
        {
            // politiky
            command.Execute();
            // log
            Debug.Print($"LOG: {command}");
        }

        public void BatchExecite(IEnumerable<ICommand> commands)
        {
            foreach(var command in commands)
            {
                ExecuteCommand(command);
            }
        }
    }
}
