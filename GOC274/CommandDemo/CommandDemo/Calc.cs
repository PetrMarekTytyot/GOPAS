using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandDemo
{
    internal class Calc : ICalc
    {
        public int Result { get; private set; }
        public void Plus(int x) => Result += x;
        public void PlusDate() => Result += DateTime.Now.Day;
    }
}
