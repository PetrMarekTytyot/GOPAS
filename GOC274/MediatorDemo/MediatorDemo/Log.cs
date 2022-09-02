using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDemo
{
    public class Log : Colleague
    {
        private int count = 1;

        public Log(Mediator mediator) : base(mediator)
        {
            mediator.Logger = this;
        }

        public void Write(string message)
        {
            Console.WriteLine($"{count}: {message}");
            count = (int)mediator.Plus(count, 1, false);
        }
    }
}
