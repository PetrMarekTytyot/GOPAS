using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodDemo
{
    public class NewCalcDependent: CalcDependent
    {
        protected override Calc CreateCalc()
        {
            return new NewCalc();
        }
    }
}
