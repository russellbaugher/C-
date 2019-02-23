using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace _442_Linq
{
    class Program
    {
        static void Main()
        {
            List<decimal> l; //generic list
            l = new List<decimal> {5,53.45M, 898.98M}; //initializer

            // Sum
            WriteLine($"Sum: {l.Sum()}");

            // Average, Min, Max
            WriteLine($"Average: {l.Average()}");
            WriteLine($"Min: {l.Min()}");
            WriteLine($"Max: {l.Max()}");

        }
    }
}
