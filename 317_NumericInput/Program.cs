using static System.Console;
class Program //identifier
{
    static void Main() //Method()
    {
        //*=multiplication
        //1. read one more value
        //2. convert the value
        //3. display the product of input1 and input2
        WriteLine("Enter Value: ");
        double input1 = double.Parse(ReadLine()); //enter a value to exe below
        WriteLine("Enter Value: ");
        double input2 = System.Double.Parse(ReadLine()); //enter a value to exe below
        WriteLine($"{input1}*{input2}={input1 * input2}");
    }
}