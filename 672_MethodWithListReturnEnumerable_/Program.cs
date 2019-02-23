using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace _672_MethodWithListReturnIEnumerable_ChooseNumsDivisibleByNum
{
    class Program
    {
        static IEnumerable<int> GrabNumbers(List<int> a, int b)
        {
            return a.Where(x => x % b == 0); //operate first, then return to body of Main()
        }

        static void Main()
        {
            List<int> l = new List<int> { 4, 6, 3, 6, 76, 7};
            foreach (int x in GrabNumbers(l, 3)) //choose divisible 
                WriteLine(x);
        }
    }
}
