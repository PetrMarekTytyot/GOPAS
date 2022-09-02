// See https://aka.ms/new-console-template for more information
using ChainOfResponsibilityDemo;

var first = new PartnerDiscountHandler();
first.Next = new VolumeDiscountHandler();

var o1 = new Order()
{
    Customer = "Gopas",
    Text = "Zirafa",
    Price = 1_500_000
};
var o2 = new Order()
{
    Customer = "Gopas",
    Text = "Krecek",
    Price = 500
};
var o3 = new Order()
{
    Customer = "Jina firma",
    Text = "Zirafa",
    Price = 1_500_000
};
var o4 = new Order()
{
    Customer = "Jina firma",
    Text = "Krecek",
    Price = 500
};

Console.WriteLine(first.Handle(o1));
Console.WriteLine(first.Handle(o2));
Console.WriteLine(first.Handle(o3));
Console.WriteLine(first.Handle(o4));
