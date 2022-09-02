using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMCalc
{
    public class PlusCommand: ICommand
    {
        private ICalc reciever;

        public PlusCommand(ICalc reciever)
        {
            this.reciever = reciever;
        }

        public int X { get; set; }

        public void Execute()
        {
            reciever.Plus(X);
        }
    }
}
