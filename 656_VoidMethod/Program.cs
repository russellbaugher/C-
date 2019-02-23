using static System.Console;

namespace _656_VoidMethods_WriteTitleBackgroundColor
{
    class Program
    {
        static void GetTitle() //void=return type, will operate, but not send output to Main() 
        {
            WriteLine($"Title: {Title}"); //display title from console window
        }

        static void GetBackgroundColor()
        {
            WriteLine($"Background Color: {BackgroundColor}"); //disp
        }

        //Call Created methods in Main()
        static void Main()
        {
            GetTitle();
            GetBackgroundColor();
        }
    }
}
