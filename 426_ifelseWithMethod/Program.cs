using static System.Console;

namespace _426_ifelseWithMethod
{
    class Program
    {
        static void Main()
        {
            string text = "hello";
            string textToFind = "ell";
            if (text.Contains(textToFind))
                WriteLine($"The text {textToFind} is found in {text}");
            else
                WriteLine($"The text {textToFind} is not found in {text}");
        }
    }
}
