using static System.Console;

namespace _430_CompoundOperators
{
    class Program
    {
        static void Main()
        {
            double x = 5;
            WriteLine($"x={x}"); //5
            WriteLine($"x={x++}"); //5, post-increment, see the effect next line
            WriteLine($"x={x}"); //6
            WriteLine($"x={++x}"); //7
            WriteLine($"x={x=x+2}"); //9
            WriteLine($"x={x+=3}"); //12
            WriteLine($"x={x/=4}"); //3
            WriteLine($"x={x*=5}"); //15
        }
    }
}
