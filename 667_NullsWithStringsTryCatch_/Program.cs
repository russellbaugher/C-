using static System.Console;
using System.Collections.Generic;

namespace _667_NullsWithStringsTryCatch_NullReferenceException
{
    class Program
    {
        static void Main()
        {
            try
            {
                string s = null;
                s.Substring(0, 1);
                List<decimal> l = null;
                l.Add(6);
            }
            catch(System.Exception ex) //Exception is a datatype,class
            {
                WriteLine(ex.Message);
            }
        }
    }
}
