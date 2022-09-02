// See https://aka.ms/new-console-template for more information
using AbstractFactoryDemo;

IShapeFactory sf = new BlueShapeFactory();


ISquare s = sf.CreateSquare();
ICircle c = sf.CreateCircle();

s.DoSomethingWithSquare();
c.DoSomethingWithCircle();
