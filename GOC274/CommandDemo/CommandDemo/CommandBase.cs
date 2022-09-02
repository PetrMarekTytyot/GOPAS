using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDemo
{
    internal abstract class CommandBase<T>: ICommand
    {
        protected T reciever;

        public CommandBase(T reciever)
        {
            this.reciever = reciever;
        }

        public virtual bool IsCompensable => false;

        public virtual void Compensate()
        {
            throw new NotImplementedException();
        }

        public abstract void Execute();
    }
}
