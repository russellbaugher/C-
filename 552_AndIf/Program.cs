using static System.Console;

namespace _552_AndIf
{
    class Program
    {
        static void Main()
        {
            if (ReadLine() == "smokes" && ReadLine() == "drinks") 
                WriteLine("no discount");
            else
                WriteLine("10% discount");
        }
    }
}
