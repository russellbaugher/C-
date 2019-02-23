using static System.Console;

namespace _433_ExitingFromWhileLoop
{
    class Program
    {
        static void Main()
        {
            BackgroundColor = System.ConsoleColor.DarkBlue;
            //Collect input until exit
            string textFinal = null; //just to have some value, null won't interfere
            string temp;
            while ((temp=ReadLine()) != "exit") //program ends on exit
                textFinal += temp + " "; //append everything into one unit

            WriteLine(textFinal);

        }
    }
}
