
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

foreach (var x in methodSyntax.ThenBy())
{
    Console.WriteLine(x.LastName + " - " + x.Salary);
}
Console.WriteLine();
foreach (var x in methodSyntax.ThenByDescending())
{
    Console.WriteLine(x.LastName + " - " + x.Salary);
}