using static System.Console;
class Program //identifier
{
    static void Main() //Method()
    {
        int x = 6, y = 10;
        WriteLine($"{x} = {y}? {x == y}"); //string, bool
        WriteLine($"{x} <= {y}? {x <= y}");
        WriteLine($"{x} > {y}? {x > y}");
        WriteLine($"{x} != {y}? {x != y}");
    }
}