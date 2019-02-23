using static System.Console;

namespace _424_SequenceOfifelseChecks
{
    class Program
    {
        static void Main()
        {
            // 4<5, 4==5, 4>5
            double x = 12, y = 10;
            if (x < y)
                WriteLine($"{x}<{y}");
            else if (x == y)
                WriteLine($"{x}={y}");
            else
                WriteLine($"{x}>{y}");
        }
    }
}
