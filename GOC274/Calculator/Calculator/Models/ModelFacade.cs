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
        private IAuth auth;

        public ModelFacade(ICalc calc, ILogger logger, IAuth auth)
        {
            this.calc = calc;
            this.logger = logger;
            this.auth = auth;
        }

        public double Result => calc.Result;

        public void Plus(double x)
        {
            var res = calc.Result;
            calc.Plus(x);
            logger.Log($"{res} + {x} = {calc.Result}");
        }

        public void Minus(double x)
        {
            var res = calc.Result;
            calc.Minus(x);
            logger.Log($"{res} - {x} = {calc.Result}");
        }

        public bool LogIn(string user, string pwd)
        {
            return auth.LogIn(user, pwd);
        }
    }
}
