
// ***** ***** . ***** *****
using Linq;

Console.WriteLine("***** ***** . ***** *****\n");

Console.WriteLine("\n");

// ***** ***** . ***** *****
Console.WriteLine("***** ***** . ***** *****\n");

Console.WriteLine("\n");

// ***** ***** . ***** *****
Console.WriteLine("***** ***** . ***** *****\n");

Console.WriteLine("\n");


// ------------------------

MethodSyntax methodSyntax = new MethodSyntax();

foreach (var x in methodSyntax.SkipWhile())
{
    Console.WriteLine(x);
}