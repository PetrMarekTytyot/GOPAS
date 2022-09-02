using StrategyDemo;

var calc = new Calc();
calc.Plus(10);
calc.SwitchToTaxing();
calc.Plus(10);
calc.SwitchToStandard();
calc.Plus(10);

Console.WriteLine(calc.Result);