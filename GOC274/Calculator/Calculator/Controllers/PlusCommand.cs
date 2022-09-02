using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Controllers
{
    public class PlusCommand : ControllerCommandBase<MainController>
    {
        public PlusCommand(MainController reciever) : base(reciever)
        {
        }

        public override bool IsCompensable => true;

        public string Input { get; set; }

        public override void Execute()
        {
            reciever.PlusAction(Input);
        }

        public override void Compensate()
        {
            reciever.MinusAction(Input);
        }
    }

}
