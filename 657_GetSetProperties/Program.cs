using static System.Console;


namespace _658_MethodWithOneParameterReturn
{
    class Program
    {
        static double AddTwo(double x)
        {
            return x + 2; //block body for methods
        }

        static decimal DivideByFive(decimal i) => i / 5; //expression body for methods

        static void Main()
        {
            double y = AddTwo(10);
            WriteLine(y);
            decimal z = DivideByFive(10.8M);
            WriteLine(z);
        }

    }
}
