using static System.Console; 
class Program //identifier
{
    static void Main() //Method()
    {
        Beep();
        string name = "Bobo";
        decimal price = 4.50M;
        double height = 15.1;
        bool hasUmbrella = true;
        string desc =
            // Call format x3, concat x2 //
            // $"Name: {name} \nPrice: {price:C} " +           
            // $"\nHeight: {height} cm " +                    
            // $"\nUmbrella: {hasUmbrella}"; //C=$ currency   

            // Call format x2, concat x1 //
            // $"Name: {name} \nPrice: {price:C} \nHeight: {height} cm "+  call
            // $"\nUmbrella: {hasUmbrella}";

            // Call format x1, concat x0 //
            $"Name: {name} \nPrice: {price:C} \nHeight: {height} \nUmbrella: {hasUmbrella}";

        WriteLine(desc);
    }
}
