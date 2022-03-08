using static System.Console;

/*
Remember that when operating on integer values, the & and | symbols are bitwise operators, 
and when operating on Boolean values like true and false, the & and | symbols are logical operators.
*/



int a = 10; // 00001010 
int b = 6; // 00000110
WriteLine($"a = {a}");
WriteLine($"b = {b}");
WriteLine($"a & b = {a & b}"); // 2-bit column only 
WriteLine($"a | b = {a | b}"); // 8, 4, and 2-bit columns 
WriteLine($"a ^ b = {a ^ b}"); // 8 and 4-bit columns