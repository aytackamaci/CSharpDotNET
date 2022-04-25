using static System.Console;

int max = 500;
int x = 0;
for (byte i = 0; i < max; i++)
{
    WriteLine(i);
    x++;
    if (x > 500) 
    {
        WriteLine("Loop is infinite, so I will break it!");
        break;
    }
} // byte 256 ya kadar çıktığı için looptan çıkamıyor :)

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 && i % 5 == 0)
    {
        Write("FizzBuzz, ");
    }
    else if (i % 3 == 0) 
    {
        Write("Fizz, ");
    }
    else if (i % 5 == 0) 
    {
        Write("Buzz, ");
    } 
    else
    {
        Write($"{i}, ");
    }
}

WriteLine("");
x = 3;
int z = 2 + x++;
int y = 2 + ++x;
WriteLine(y);
WriteLine(z);
Write("Enter a number between 0 and 255: ");
string? firstNumber = ReadLine();
Write("Enter another number between 0 and 255: ");
string? secondNumber = ReadLine();

if(int.TryParse(firstNumber, out int first) && int.TryParse(secondNumber, out int second)) 
{
    WriteLine($"{first} divided by {second} is {first/second}.");
}
else 
{
    WriteLine("FormatException: Input string was not in a correct format.");
}