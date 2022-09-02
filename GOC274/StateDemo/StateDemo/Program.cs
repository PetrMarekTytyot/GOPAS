using StateDemo;

var doc = new Document();
Console.WriteLine(doc.IsValid);
doc.Approve();
Console.WriteLine(doc.IsValid);
doc.Title = "Ahoj";
doc.Archive();
doc.Title = "Nazdar";