using static System.Console;

namespace _551_DecideOnTwoConditionsWithAnd
{
    class Program
    {
        static void Main()
        {
            WriteLine(4 > 3 && 5 == 5); //true
            WriteLine(2 > 5 && 4 > 3);  //false
            WriteLine(5 > 2 && 3 > 4);  //false
            WriteLine(1 > 2 && 1 != 1);  //false
        }
    }
}
