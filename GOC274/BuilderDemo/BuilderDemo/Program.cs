using BuilderDemo;

var builder = new VehicleBuilder();
var director = new VehilcleDirector(builder);

director.BuildCar();
var car = builder.GetVehilce();

director.BuildBike();
var bike = builder.GetVehilce();

Console.WriteLine($"Car: {car}");
Console.WriteLine($"Bike: {bike}");