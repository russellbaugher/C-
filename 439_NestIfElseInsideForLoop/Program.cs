using static System.Console;

namespace _439_NestIfElseInsideForLoop
{
    class Program
    {
        static void Main()
        {
            string s = "$33jk4(*)jlj.#$.";
            foreach (char c in s)
            //WriteLine(c); // Writes each char on a line
            //WriteLine((int)c); // Writes numerical code for each char
            {
                if (char.IsNumber(c)) //picks out 334 //other options IsPunctution
                    WriteLine(c);
            }
        
        }
    }
}