using static System.Console; //System goes into use
class Program //identifier
{
    static void Main() //Method()
    {
        // Int32 maxValue 2147483647
        // decimal maxValue 79228162514264337593543950335M
        decimal bobSalary = 50000M,
                johnSalary = 100000M,
                adilSalary = 80000;
        decimal sum = bobSalary + johnSalary + adilSalary;
        //WriteLine($"Sum: {bobSalary + johnSalary:C}"); //:C = $
        WriteLine($"Sum: {sum:C}");
        //WriteLine($"Average:{(bobSalary + johnSalary) / 2:C}");   
        WriteLine($"Average:{sum / 3:C}");
    }
}
