using static System.Console;

string? password;
int count = 0;

string[] names = { "Adam", "Barry", "Charlie" };
foreach (string name in names)
{
    WriteLine($"{name} has {name.Length} characters.");
}

do
{
  Write("Enter your password: ");
  password = ReadLine();
  count++;
}
while ((password != "password") && count < 10);
WriteLine("Correct!");