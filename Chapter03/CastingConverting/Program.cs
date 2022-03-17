using static System.Console;

Write("How many eggs are there? ");
string? input = ReadLine(); // or use "12" in notebook
if (int.TryParse(input, out int count)) // TryParse returns true if successfull false if not. out sets count as parsed int.
{
    WriteLine($"There are {count} eggs.");
}
else
{
    WriteLine("I could not parse the input.");
}

