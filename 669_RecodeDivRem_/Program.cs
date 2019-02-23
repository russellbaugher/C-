using static System.Console;

namespace _669_RecodeDivRem_QuotientRemainder
{
    public class Program
    {
        static int DivRem(int a, int b, out int remainder) //DivisionRemainder
        {
            if(b!=0)
            {
                remainder = a % b;  //remainder
                return a / b;       //quotient
            }
            else
            {
                remainder = 0;
                return 0;
            }


        }

        public static void Main()
        {
            WriteLine($"quotient: {DivRem(15, 2, out int r)}\nremainder: {r}");
        }
    }
}
