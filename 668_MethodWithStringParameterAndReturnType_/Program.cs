using static System.Console;

namespace _668_MethodWithStringParameterAndReturnType_GetFirstLetter
{
    class Program
    {
        static string GetFirstLetter(string s)
        {
            if (s == null)
                return "input was null"; //eliminate err
            else
                return s.Substring(0, 1);
        }

        static void Main()
        {
            //WriteLine(GetFirstLetter(null));
            WriteLine($"The first letter is: {GetFirstLetter("hello")}");
        }
    }
}
