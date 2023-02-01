
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

foreach(var x in methodSyntax.TakeWhile())
{
    Console.WriteLine(x);
}