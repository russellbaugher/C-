using static System.Console;

namespace _776_ArrayMultiplicationMethod
{
    class Program
    {
        static double Multiply(params double[] a)
        {
            double product = 1; //start with 1 to calibrate multiplication (0 will prod 0)
            foreach (double x in a)
                product *= x; //accumulate entire product 1*1.0*2.4*3*4*...
            return product;
        }
        static void Main()
        {
            WriteLine(Multiply(1.0, 2.3, 3.1, 4, 5, 6, 7));
        }
    }
}
