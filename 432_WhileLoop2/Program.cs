using static System.Console;

namespace _432_WhileLoop2
{
    class Program
    {
        static void Main()
        //{
        //    //1. print 100,99,98,...,1,0
        //    int loopCounter = 100;
        //    while(loopCounter>=0)
        //    {
        //        WriteLine($"value = {loopCounter}");
        //        loopCounter-=1;
        //    }
        //}

        {
            //2. print 500,495,490,...,5,0
            int loopCounter = 500;
            while (loopCounter >= 0)
            {
                WriteLine($"value = {loopCounter}");
                loopCounter -= 5;
            }
        }
    }
}
