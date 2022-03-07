using static System.Console;

/*
^ operator returns true when one of two operands is true, but not both! 
*/
bool a = true;
bool b = false;

static bool DoStuff() 
{
    WriteLine("I'm here.");
    return true;
}

WriteLine();
WriteLine($"a & DoStuff() = {a & DoStuff()}");
WriteLine($"b & DoStuff() = {b & DoStuff()}");

WriteLine($"a && DoStuff() = {a && DoStuff()}");
WriteLine($"b && DoStuff() = {b && DoStuff()}");