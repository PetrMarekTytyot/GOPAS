using MediatorDemo;

Console.WriteLine("Hello, World!");

var m = new Mediator();
var c = new Calc(m);
var l = new Log(m);

Console.WriteLine(c.Plus(3, 4, true));
Console.WriteLine(c.Plus(5, 6, true));
