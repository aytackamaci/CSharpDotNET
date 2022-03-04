using static System.Console;

int numberOfApples = 12;
decimal pricePerApple = 0.35M;
WriteLine(
  format: "{0} apples costs {1:C}",
  arg0: numberOfApples,
  arg1: pricePerApple * numberOfApples);
string formatted = string.Format(
  format: "{0} apples costs {1:C}",
  arg0: numberOfApples,
  arg1: pricePerApple * numberOfApples);
WriteLine(formatted);  
//WriteToFile(formatted); // writes the string into a file
WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");

Write("Type your first name and press ENTER: ");
string? firstName = ReadLine();
Write("Type your age and press ENTER: ");
string? age = ReadLine();
WriteLine($"Hello {firstName}, you look good for {age}.");

Write("Press any key combination: ");
ConsoleKeyInfo key = ReadKey();
WriteLine();
WriteLine("Key: {0}, Char: {1}, Modifiers: {2}",
  arg0: key.Key,
  arg1: key.KeyChar,
  arg2: key.Modifiers);