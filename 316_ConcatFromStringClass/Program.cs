using static System.Console;
class Program //identifier
{
    static void Main() //Method()
    {
        string s1 = "hello";
        string s2 = ", world ";
        string s3 = "\nGood morning";
        string s4 = System.String.Concat(s1, s2, s3);
        WriteLine(s4);
    }
}
