using System;

namespace ITMO.CScourse.Divider
{
    class DivideIt
    {
        static void Main(string[] args)
        {
            ITMO.CScourse.Divider.TestLibrary.Algorithm alg = new ITMO.CScourse.Divider.TestLibrary.Algorithm();
            alg.Run();

            Console.ReadKey();
        }
    }
}
