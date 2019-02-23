using static System.Console;
using System;

namespace _553_TryParseWhileAndBreakContinue
{
    class Program
    {
        static void Main()
        {
            while(true)
            {
                Clear(); //clear after each operation
                bool firstConverted = double.TryParse(ReadLine(), out double v1);
                bool secondConverted = double.TryParse(ReadLine(), out double v2);
                if (firstConverted && secondConverted)
                    WriteLine($"{v1}/{v2} = {v1 / v2}");

                ConsoleKey k = ReadKey(true).Key; //true prevents key box being displayed
                if(k==ConsoleKey.Escape)
                    break;
            }
            WriteLine();
        }
    }
}
