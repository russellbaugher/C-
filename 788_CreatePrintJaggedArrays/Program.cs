using static System.Console;

namespace _788_CreatePrintJaggedArrays
{
    class Program
    {
        static void Main()
        {
            //Array of arrays
            int[][] grades = { 
                               new int[] { 78, 67, 89 },  //student array
                               new int[] { 89, 76 },
                               new int[] { 88, 75, 93, 67, 99 }
                             };
            //grab individual array in grades array
            foreach (int[] student in grades)
            {
                foreach (int x in student)
                    Write($"{x}  "); //Write one array
                    WriteLine(); //Force new line after each array
            }
        }
    }
}
