using static System.Console; //System goes into use
class Program //identifier
{
    static void Main() //Method()
    {
        WriteLine("Write Input");
        string s = ReadLine();
        WriteLine(s.ToUpper());
        WriteLine(s.ToLower());
    }
}