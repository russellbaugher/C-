using static System.Console;

namespace _781_StepThruArrayWithForLoop_MultiplyUpDown
{
    class Program
    {
        static void Main()
        {
            decimal[] a = new decimal[100]; //[5]=size
            //indexes: 0,1,2,3,4
            for (int i = 0; i < a.Length; i++) //Length=5 
                a[i] = i * i;

            //Write Array Results, low to high
            for (int i = 0; i < a.Length; i++)
                WriteLine(a[i]); //Array line access notation

            WriteLine("\nReverse Direction\n");

            //Write Array Results, high to low
            for (int i = a.Length - 1; i >= 0; i--)
            WriteLine(a[i]);

        }
    }
}
