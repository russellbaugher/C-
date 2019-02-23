using static System.Console;

namespace _438_StringsWithForLoops
{
    class Program
    {
        static void Main()
        {
            //string s = "Hello";
            //for (int i = 1; i <= s.Length; i++)
            //    WriteLine(s.Substring(i-1, 1)); // Write each index on separate line

            //string s = "Hello";
            //for (int i = 0; i < s.Length; i++)
            //    WriteLine(s.Substring(i, 1));

            //Reverse string
            string s = "Hello";
            for (int i = s.Length-1; i >= 0; i--)
                WriteLine(s.Substring(i, 1));
        }
    }
}
