using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDemo
{
    internal class PlusCommand : CommandBase<ICalc>
    {
        public PlusCommand(ICalc reciever) : base(reciever)
        {
        }

        public int X { get; set; }

        public override void Execute()
        {
            reciever.Plus(X);
        }

        public override bool IsCompensable => true;

        public override void Compensate()
        {
            reciever.Plus(-X);
        }
    }
}
