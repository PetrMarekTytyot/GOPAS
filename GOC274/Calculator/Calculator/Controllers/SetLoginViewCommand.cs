using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Controllers
{
    internal class SetLoginViewCommand : ControllerCommandBase<LoginController>
    {
        public SetLoginViewCommand(LoginController reciever) : base(reciever)
        {
        }

        public IView LoginView { get; set; }

        public override void Execute()
        {
            reciever.LogInView = LoginView;
        }
    }
}
