using static System.Console;

namespace _775_ArrayParams_AdditionMethod
{
    class Program
    {
        static double Add(params double[] a)
        {
            double sum = 0; //start with 0 to calibrate
            foreach (double x in a)
                sum += x; //accumulate entire sum
            return sum;
        }
        static void Main()
        {
            WriteLine(Add(1.0, 2.4, 3, 4, 5, 6, 7, 8, 3, 54, 7));
        }
    }
}
