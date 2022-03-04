using System.Xml;

object height = 1.88; // storing a double in an object 
object name = "Amir"; // storing a string in an object 
Console.WriteLine($"{name} is {height} metres tall.");
//int length1 = name.Length; // gives compile error!
int length2 = ((string)name).Length; // tell compiler it is a string 
Console.WriteLine($"{name} has {length2} characters.");

dynamic something = "Ahmed";
Console.WriteLine($"Length is {something.Length}"); // does not give compile error because its type is dynamic


// good use of var because it avoids the repeated type 
// as shown in the more verbose second statement
var xml1 = new XmlDocument();
XmlDocument xml2 = new XmlDocument();
// bad use of var because we cannot tell the type, so we 
// should use a specific type declaration as shown in
// the second statement
var file1 = File.CreateText("something1.txt"); 
StreamWriter file2 = File.CreateText("something2.txt");

Console.WriteLine($"default(int) = {default(int)}");
Console.WriteLine($"default(bool) = {default(bool)}");
Console.WriteLine($"default(DateTime) = {default(DateTime)}");
Console.WriteLine($"default(string) = {default(string)}");

string[] names;
names = new string[4];

names[0] = "Kate";
names[1] = "Jack";
names[2] = "Rebecca";
names[3] = "Tom";
// looping through the names
for (int i = 0; i < names.Length; i++)
{
    // output the item at index position i
    Console.WriteLine(names[i]);
}

string[] names2 = new[] { "Kate", "Jack", "Rebecca", "Tom" };