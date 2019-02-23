using static System.Console;
class Program //identifier
{
    static void Main() //Method()
    {
        Title = "Method Chaining";
        BackgroundColor = System.ConsoleColor.DarkGreen;
        string s = "   Hello, World!  ";
        WriteLine(s.ToUpper()); //returns a copy of s, does not change it
        WriteLine(s);
        WriteLine(s.Trim());
        WriteLine(s); //spaces are back
        WriteLine(s.Trim().ToUpper()); //chained
    }
}