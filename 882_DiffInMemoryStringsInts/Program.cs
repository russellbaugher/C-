using static System.Console;
using System.Collections.Generic;

namespace _782_DiffInMemoryStringsInts
{
    class Program
    {
        static void Main()
        {
            string[] names1 = { "bob", "tom" };
            string[] names2 = names1; //same in memory
            int[] x = { 1, 2 };
            double p = 20;
            p += 10;
        }
    }
}
