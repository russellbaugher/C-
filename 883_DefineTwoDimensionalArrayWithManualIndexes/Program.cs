using static System.Console;

namespace _783_TwoDimensionalArrayWithManualIndexes
{
    class Program
    {
        static void Main()
        {
            decimal[,] a = new decimal[2, 2]; //2x2 array
            a[0, 0] = 10; a[0, 1] = 30;
            a[1, 0] = 40; a[1, 1] = 50;
            WriteLine(a[0,1]); //30
            WriteLine(a[1, 1]/a[0,0]); //5
            WriteLine($"{a[1, 0]:C}"); //$40
        }
    }
}
