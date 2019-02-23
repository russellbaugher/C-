using static System.Console;
using System.Collections.Generic;

namespace _778_ArraysListsRefsMemory
{
    class Program
    {
        static void Main()
        {
            //Array Memory Behavior
            double[] a1 = { 1, 2 };
            double[] a2 = a1; //point to same place in memory; diff names for same array
            a2[0] = 10;
            WriteLine(a1[0]); //10 a1=a2, a1 & a2 point to same array

            //List Memory Behavior
            List<double> l1 = new List<double> { 4, 5, 3, 6 };
            List<double> l2 = l1; //point to same place in memory; diff names for same list
            List<double> l3 = l2;
        }
    }
}
