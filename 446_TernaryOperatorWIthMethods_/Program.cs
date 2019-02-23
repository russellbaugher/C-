using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace _446_TernaryOperatorWIthMethods_
{
    class Program
    {
        static void Main()
        {
            //bool result = ReadLine().Contains(ReadLine())?true:false; // two prompts
            //WriteLine(result);
            
            // More concise
            WriteLine(ReadLine().Contains(ReadLine()));
        }
    }
}
