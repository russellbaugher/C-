using static System.Console;

namespace _435_ForLoop_
{
    class Program
    {
        static void Main()
        //{
        //    //1. print cubes of: 10,9,8 
        //    for (int i = 10; i >= 8; i--)
        //        WriteLine($"{i}*{i}*{i} = {i * i * i}"); // 1000, 729, 512
        //}

        {
            //2. print squares of: 11,8,5 
            for (int i = 11; i >= 5; i-=3)
                WriteLine($"{i}*{i} = {i * i}"); // 121,64,25
        }
    }
}
