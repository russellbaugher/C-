using static System.Console;


namespace _786_FillTwoDimensionalArrayWithForLoops_MatrixBuilder
{
    class Program
    {
        static void Main()
        {
            //row indexes go: 0 to 9
            //column indexes go: 0 to 19
            string[,] arr = new string[10, 20];
            //Fill with for loops
            //Rows
            for (int r = 0; r < arr.GetLength(0); r++)  //iterate over row indexes
            {   //Columns
                for (int c = 0; c < arr.GetLength(1); c++) //why 1?
                    arr[r, c] = $"[{r},{c}]";
            }

            for (int r = 0; r < arr.GetLength(0); r++)  //iterate over row indexes
            {
                for (int c = 0; c < arr.GetLength(1); c++) //why 1?
                    Write($"{arr[r,c]}"); //write a row

                WriteLine(); //force new rows onto separate line
            }
        }
    }
}
