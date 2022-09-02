using CompositeAndInterpreterDemo;

var expression = new Sum(
    new Literal(3),
    new Product(
        new Variable("x"),
        new Variable("y")
        )
    );

var context = new Dictionary<string, int>()
{
    {"x", 5 },
    {"y", 6},
};

Console.WriteLine(expression.Interpret(context));