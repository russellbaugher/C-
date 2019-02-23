using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace _443_ListsWithForEach
{
    class Program
    {
        static void Main()
        {
            //List<string> l = new List<string> { "bob", "jane" };
            //l.ForEach(x => WriteLine(x.ToUpper()));
            //l.ForEach(x => WriteLine(x.ToLower()));

            List<decimal> l = new List<decimal> {1, 2};
            l.ForEach(x => WriteLine($"{x}^2 = {x*x}"));
        }
    }
}
