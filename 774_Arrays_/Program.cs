using static System.Console;


namespace _774_ArrayAccessNotation
{
    class Program
    {
        static void Main()
        {
            int[] a;
            a = new int[] { 4, 5, 6, 9 };
            WriteLine(a[0]); //array access notation
            WriteLine(a[1]);
            WriteLine(a[2]);
            WriteLine(a[3]);
            a[0] = 20;       //change values
            a[2] = 10;
            a[3] = 15;
            WriteLine(a[0]); //20
            WriteLine(a[1]); //5
            WriteLine(a[2]); //10
            WriteLine(a[3]); //15
            WriteLine(a[0] + a[3]); //35




        }
    }
}
