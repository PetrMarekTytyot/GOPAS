using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList.Presenters
{
    public class AddActionCommand : ICommand
    {
        private IMainPresenter reciever;
        public AddActionCommand(IMainPresenter reciever)
        {
            this.reciever = reciever;
        }

        public bool IsCompensable => false;

        public void Compensate()
        {
            throw new NotImplementedException();
        }

        public void Execute()
        {
            reciever.AddAction();
        }
    }
}
