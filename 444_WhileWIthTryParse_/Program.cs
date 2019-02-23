using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace _444_WhileWithTryParse_SumAverageOfList
{
    class Program
    {
        static void Main()
        {
            List<double> l = new List<double>(); //no initializer, user will decide how many in list
            // "10", "ten"
            while (double.TryParse(ReadLine(), out double result))
                l.Add(result);

            // show sum and average of list
            WriteLine($"Sum: {l.Sum()}" + 
               $"\nAverage: {l.Average()}");
        }
    }
}
