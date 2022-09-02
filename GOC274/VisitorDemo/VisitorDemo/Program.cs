using VisitorDemo;
using Attr = VisitorDemo.Attribute;

Attr a = new Attr();
Element e = new Element();

SetValueVisitor v1 = new SetValueVisitor("ahoj");
a.AcceptVisitor(v1);
e.AcceptVisitor(v1);

Console.WriteLine(a.Value);
Console.WriteLine(e.InnerText);

SetUCaseValueVisitor v2 = new SetUCaseValueVisitor("ahoj");
a.AcceptVisitor(v2);
e.AcceptVisitor(v2);

Console.WriteLine(a.Value);
Console.WriteLine(e.InnerText);