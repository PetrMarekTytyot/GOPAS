using ProxyAndDecoratorDemo;

var calc = new Calc();
var intercepting = new WeekendPolicyProxy(calc);
var logging = new LoggingDecorator(intercepting);
var rounding = new RoundingProxy(logging);

var cc = new CalcClient(rounding);
Console.WriteLine(cc.HalfPlusHalf());