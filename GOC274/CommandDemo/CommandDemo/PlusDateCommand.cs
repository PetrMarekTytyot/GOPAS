using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDemo
{
    internal class PlusDateCommand : CommandBase<Calc>
    {
        public PlusDateCommand(Calc reciever) : base(reciever)
        {
        }

        private int day;

        public override void Execute()
        {
            reciever.PlusDate();
            day = DateTime.Now.Day;
        }

        public override bool IsCompensable => true;
        public override void Compensate()
        {
            reciever.Plus(-day);
        }
    }
}
