using static System.Console;

namespace _663_SwitchBlocks_RecreateMath.Sign
{
    class Program
    {
        //public static int Sign(decimal Value)
        //{
        //    if (value < 0)
        //        return -1;
        //    else if (value > 0)
        //        return 1;
        //    else
        //        return 0;
        //}

        static int Sign(decimal value)
        {
            switch(value)
            {
                case decimal d when value < 0: //d represents value passed in
                    return -1;
                case decimal d when value > 0:
                    return 1;
                default:
                    return 0;
            }
        }

        static void Main()
        {
            WriteLine(Sign(-45.3M));                //my version        //-1
            WriteLine(System.Math.Sign(-45.3M));    //System's version  //-1
        }
    }
}
