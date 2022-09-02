using AdapterAndBridgeDemo;

var a = new CalcAdapter();
var cc = new CalcClient(a);

Console.WriteLine(cc.OnePlusOne());