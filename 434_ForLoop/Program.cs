using static System.Console;

namespace _434_ForLoop
{
    class Program
    {
        static void Main()
        //{
        //    //1. Print squares of: 1,2,3,4,5 (squares: 1,4,9,16,25)
        //    for (int i = 1; i <= 5; i++) //declare, initialize, increment
        //        WriteLine($"{i}*{i}={i * i}");
        //}

        //{
        //    //2. Print squares of: 1,3,5,7,9 (squares: 1,9,25,49,81)
        //    for (int i = 1; i <= 9; i+=2) //declare, initialize, increment
        //        WriteLine($"{i}*{i}={i * i}");
        //}

        {
            //3. Print cubes of: 5,6,7 (cubes: 125,216,343)
            for (int i = 5; i <= 7; i++) //declare, initialize, increment
                WriteLine($"{i}*{i}*{i} = {i * i * i}");
        }
    }
}

