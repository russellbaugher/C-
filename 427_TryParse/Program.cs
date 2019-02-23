using static System.Console;
namespace _427_TryParse
{
    class Program
    {
        static void Main()
        {
            WriteLine("Enter First Value");
            string s1 = ReadLine();
            if (double.TryParse(s1, out double value1)) // Tells if conversion is successful & gives value for calculations //1st check
            {
                WriteLine("Enter Second Value:");
                string s2 = ReadLine();
                if (double.TryParse(s2, out double value2)) //2nd check
                    WriteLine($"{value1} * {value2} = {value1 * value2}");
                else
                    WriteLine("Second input cant't be converted to numerical form"); //2nd failure
            }
            else
                WriteLine("First input can't be converted to numerical form"); //1st failure
        }
    }
}
