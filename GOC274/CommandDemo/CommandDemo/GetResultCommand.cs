using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDemo
{
    internal class GetResultCommand : CommandBase<ICalc>
    {
        public GetResultCommand(ICalc reciever) : base(reciever)
        {
        }

        public int Result { get; private set; }

        public override void Execute()
        {
            Result = reciever.Result;
        }
    }
}
