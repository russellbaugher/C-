using static System.Console;

namespace _661_MethodTwoParametersOneReturn_InterestCalculator
{
    class Program
    {
        //interest = amount * rate * time
        //interest = 1000 * 0.05 * 2 (years)

        static decimal FindInterest(decimal amount, decimal rate, decimal time) //static allows method to be found in Main()
        {
            WriteLine($"Amount of {amount:C} at a Rate of {rate} for {time} Years"); //write parameters to user
            if (amount > 0 && rate > 0 && time > 0)
                return amount * rate * time;
            else
                return 0M; //M forces into decimal datatype //no interest           
        }

        static void Main()
        {
            decimal interest = FindInterest(10000, 0.05M, 2);
            WriteLine($"Interest: {interest:C}");
        }
    }
}
