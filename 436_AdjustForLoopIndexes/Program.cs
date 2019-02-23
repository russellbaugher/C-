using static System.Console;

namespace _436_AdjustForLoopIndexes
{
    class Program
    {
        static void Main()
        //{
        //    //1. use 1+2, 2+2, 3+2 
        //    //2. to create: 1*1, 2*2, 3*3
        //    for (int i = 3; i <= 5; i++)
        //        WriteLine($"{i-2}*{i-2}={(i-2) * (i-2)}"); //-2 to compensate
        //}

        {
            //1. use 1-3, 2-3, 3-3 
            //2. to create: 1*1, 2*2, 3*3
            for (int i = -2; i <= 0; i++)
                WriteLine($"{i + 3}*{i + 3}={(i + 3) * (i + 3)}"); //+3 to compensate
        }
    }
}
