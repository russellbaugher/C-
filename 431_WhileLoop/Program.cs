using static System.Console;

namespace _431_WhileLoop
{
    class Program
    {
        static void Main()
        //{
        //    //1. print: 1,2,3,4,5,6,7,8,9,10
        //    int loopcounter = 1;
        //    while(loopcounter <= 10) //10<=10
        //    {
        //        writeline($"value = {loopcounter}");
        //        loopcounter++;
        //    }
        //}

        {
            //2. print: 5,10,15,20,25,30
            int loopCounter = 5;
            while (loopCounter <= 30) //30<=30
            {
                WriteLine($"value = {loopCounter}");
                loopCounter+=5;
            }
        }
    }
}
