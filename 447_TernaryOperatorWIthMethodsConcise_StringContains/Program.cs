using static System.Console;

namespace _448_SwitchBlocks_
{
    class Program
    {
        static void Main()
        {
            string op = "/";
            double x = 5, y = 7;
            switch(op)
            {
                case "+":
                    WriteLine($"{x} + {y} = {x + y}");
                    break;
                case "-":
                    WriteLine($"{x} - {y} = {x - y}");
                    break;
                case "*":
                    WriteLine($"{x} * {y} = {x * y}");
                    break;
                case "/":
                    if (y != 0) //division by 0 exception
                         WriteLine($"{x} / {y} = {x / y}");
                    else
                        WriteLine("Cannot divide by zero");
                    break;

            }
        }
    }
}
