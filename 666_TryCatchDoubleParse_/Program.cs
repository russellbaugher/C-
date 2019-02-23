using static System.Console;

namespace _666_TryCatchDoubleParse_CatchNonDoubleTypesWithErrMessage
{
    class Program
    {
        static void Main()
        {
            WriteLine($"Enter a number to be multiplied by 5");
            try
            {
                double x = double.Parse(ReadLine());
                WriteLine($"{x * 5}");
            }
            catch (System.FormatException ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}
