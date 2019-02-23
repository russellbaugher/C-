using static System.Console;


namespace _664_MethodsWithExceptionsTryCatch_DivideByZeroException
{
    class Program
    {
        //public static int DivRem(int a, int b, out int result)
        //{
        //    result = a % b;
        //    return a / b;
        //}

        static void Main()
        {
            try
            {
                int quotient = System.Math.DivRem(5, 1, out int remainder); 
                WriteLine($"quotient: {quotient}, remainder: {remainder}");
            }
            catch(System.DivideByZeroException ex)
            {
                WriteLine(ex.Message); //"attempted to divide by zero"
                WriteLine(ex.Source); //mscorlib
                WriteLine(ex.StackTrace); //which methods have been called
            }
            //int quotient = System.Math.DivRem(5, 2, out int remainder); //public, so can be accessed in Main()\
            //WriteLine($"quotient: {quotient}, remainder: {remainder}"); // q:2 r:1
        }
    }
}
