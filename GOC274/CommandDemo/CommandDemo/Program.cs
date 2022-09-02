// See https://aka.ms/new-console-template for more information
using CommandDemo;

Console.WriteLine("Hello, World!");

var calc = new Calc();

var cmd1 = new PlusCommand(calc);
var cmd2 = new PlusCommand(calc);
var gr = new GetResultCommand(calc);

//...

cmd1.X = 5;
cmd2.X = 6;

//...

var invoker = new Invoker();
invoker.BatchExecite(new List<ICommand>() { cmd1, cmd2, gr });

Console.WriteLine(gr.Result);

var cf = new CommandFactory(calc);
invoker.ExecuteCommand(cf.CreatePlusCommand(7));
invoker.ExecuteCommand(gr);
Console.WriteLine(gr.Result);

var cmdProc = new CommandProcessor();
cmdProc.ExecuteCommand(cf.CreatePlusCommand(5));
cmdProc.ExecuteCommand(cf.CreatePlusCommand(6));
cmdProc.ExecuteCommand(gr);
Console.WriteLine(gr.Result);
cmdProc.CompensateLastCommand();
cmdProc.ExecuteCommand(gr);
Console.WriteLine(gr.Result);
cmdProc.CompensateLastCommand();
cmdProc.ExecuteCommand(gr);
Console.WriteLine(gr.Result);
