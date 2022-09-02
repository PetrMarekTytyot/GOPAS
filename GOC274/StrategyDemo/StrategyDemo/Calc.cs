using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyDemo
{
    public class Calc
    {
        private interface IPlusStrategy
        {
            void Plus(double x);
        }

        private abstract class PlusStrategyBase: IPlusStrategy
        {
            protected Calc calc;

            protected PlusStrategyBase(Calc calc)
            {
                this.calc = calc;
            }

            public abstract void Plus(double x);
        }

        private class StandardPlusStrategy : PlusStrategyBase
        {
            public StandardPlusStrategy(Calc calc) : base(calc)
            {
            }

            public override void Plus(double x)
            {
                calc.Result += x;
            }
        }

        private class TaxingPlusStrategy : PlusStrategyBase
        {
            public TaxingPlusStrategy(Calc calc) : base(calc)
            {
            }

            public override void Plus(double x)
            {
                calc.Result += x * .9;
            }
        }

        private IPlusStrategy plusStrategy;

        public Calc()
        {
            plusStrategy = new StandardPlusStrategy(this);
        }

        public void SwitchToStandard()
        {
            plusStrategy = new StandardPlusStrategy(this);
        }

        public void SwitchToTaxing()
        {
            plusStrategy = new TaxingPlusStrategy(this);
        }

        public double Result { get; private set; }

        
        public void Plus(double x)
        {
            plusStrategy.Plus(x);
        }
    }
}
