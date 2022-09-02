using MEFDemo;

var p = new App();
Console.WriteLine("Enter Command:");
while (true)
{
    string s = Console.ReadLine();
    Console.WriteLine(p.calculator.Calculate(s));
}