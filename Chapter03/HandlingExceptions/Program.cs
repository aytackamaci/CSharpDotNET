using static System.Console;

WriteLine("Before parsing");
Write("What is your age?");

string? input = ReadLine();

if (input == null) {
    input = "15";
}

try 
{
    int age = int.Parse(input);
    WriteLine($"Your age is {age}.");
}
catch (OverflowException)
{
    WriteLine("Your age is a valid number format but it is either too big or small.");
}
catch (Exception ex)
{
    WriteLine("Cannot parse, King.");
    WriteLine($"{ex.GetType()} says {ex.Message}");
}

WriteLine("After parsing");

Write("Enter an amount: ");
string? amount = ReadLine();

if (amount == null) {
    amount = "15";
}

try
{
    decimal amountValue = decimal.Parse(amount);
}
catch (FormatException) when (amount.Contains("$")) // when can be used while giving exceptions a condition
{
    WriteLine("Amounts cannot use the dollar sign!");
}
catch (FormatException)
{
    WriteLine("Amounts must only contain digits!");
}