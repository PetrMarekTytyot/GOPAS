using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Models
{
    public class ModelFacade : IModelFacade
    {
        private ICalc calc;
        private ILogger logger;

        public ModelFacade(ICalc calc, ILogger logger)
        {
            this.calc = calc;
            this.logger = logger;
        }

        public double Result => calc.Result;

        public void Plus(double x)
        {
            var res = calc.Result;
            calc.Plus(x);
            logger.Log($"{res} + {x} = {calc.Result}");
        }
    }
}
