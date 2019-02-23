using static System.Console;

namespace _555_MultipleOrsForEach_VowelCounter
{
    class Program
    {
        static void Main()
        {
            string s = ReadLine();
            //hello
            int vowelCount = 0;
            foreach (char c in s)
                //a,e,i,o,u
                if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') //'' for char data type
                    vowelCount++;

            WriteLine($"vowel count: {vowelCount}");
            WriteLine($"other count: {s.Length - vowelCount}");

        }
    }
}
