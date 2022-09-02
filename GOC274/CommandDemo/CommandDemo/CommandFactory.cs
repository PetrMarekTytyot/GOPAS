using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDemo
{
    internal class CommandFactory
    {
        private ICalc reciever;

        public CommandFactory(ICalc reciever)
        {
            this.reciever = reciever;
        }

        public PlusCommand CreatePlusCommand(int x) =>
            new PlusCommand(reciever) { X = x };

        public GetResultCommand CreateGetResultCommand() =>
            new GetResultCommand(reciever);
    }
}
