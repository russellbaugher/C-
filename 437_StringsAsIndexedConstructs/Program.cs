using static System.Console;

namespace _437_StringsAsIndexedConstructs
{
    class Program
    {
        static void Main()
        {
            string s = "Hello"; //index 0:H 1:e 2:l 3:l 4:o
            WriteLine(s.Length);
            WriteLine(s.Substring(0, 1)); //H (start,length)
            WriteLine(s.Substring(1, 1)); //e
            WriteLine(s.Substring(2, 1)); //l
            WriteLine(s.Substring(3, 1)); //l
            WriteLine(s.Substring(4, 1)); //o
            //WriteLine(s.Substring(5, 1)); //err
            WriteLine(s.Substring(s.Length-1, 1)); // 5-1 = index:4 = o
        }
    }
}
