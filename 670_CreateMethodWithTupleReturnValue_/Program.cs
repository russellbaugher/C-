using static System.Console;

namespace _670_CreateMethodWithTupleReturnValue_
{
    class Program
    {
        static (string name, string age) Parse(string info)
        {
            string name = info.Substring(0, info.IndexOf(","));
            string age = info.Substring(info.IndexOf(",") + 1);
            return (name, age); //fixes "not all code paths return a value"
        }
        static void Main()
        {
            string s = "JohnSmithIII,45";
            WriteLine($"{Parse(s).name}" +
                $"\n{Parse(s).age}");

        }
    }
}
