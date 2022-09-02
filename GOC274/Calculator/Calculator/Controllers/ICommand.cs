using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Controllers
{
    public interface ICommand
    {
        bool IsCompensable { get; }
        void Execute();
        void Compensate();
    }
}
