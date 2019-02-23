using static System.Console;

namespace _777_ParamsSplitMethodFromStringClass_RemoveChars
{
    class Program
    {
        static void Main()
        {
            //'r' is not same as "r"
            string s = "john,adam.bibi;ret-bob.bill";
            char[] sep = { ',', '.', ';','-' };
            string[] names = s.Split(sep);
            foreach(string name in names)
                WriteLine(name);
        }
    }
}
