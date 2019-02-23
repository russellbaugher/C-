using static System.Console;
using System.Collections.Generic;

namespace _780_PassingByRefAndValue
{
    class Program
    {
        //Methods that accept array in a list
        static void ChangeArray(int[] a) => a[0] = 500; 
        static void ChangeList(List<decimal> b) => b[0] = 1000;
        static void ChangeValue(double c) => c = 2000;

        static void Main()
        {
            int[] x = { 3, 4 };
            ChangeArray(x);
            WriteLine(x[0]); //500  a=x
            List<decimal> l = new List<decimal> { 2, 3, 5, 6 };
            ChangeList(l);
            WriteLine(l[0]); //1000 b=l
            double z = 23; //change value w/ChangeValue
            ChangeValue(z); //sends copy of data, does NOT change c; z!=c
            WriteLine(z);

        }
    }
}