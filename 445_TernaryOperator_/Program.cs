using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace _445_TernaryOperator_TrueFalse
{
    class Program
    {
        static void Main()
        {
            decimal x = 5, y = 6;
            string s = (x == y) ? "same" : "different"; // (bool) ? true : false; 
            WriteLine(s);
        }
    }
}
