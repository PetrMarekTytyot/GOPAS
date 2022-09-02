using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorDemo
{
    public abstract class Colleague
    {
        protected Mediator mediator;

        protected Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
