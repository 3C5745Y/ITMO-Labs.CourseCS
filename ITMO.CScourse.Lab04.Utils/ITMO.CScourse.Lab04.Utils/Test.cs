using System;

namespace ITMO.CScourse.Lab04.Utils
{
    /// <summary>
    /// This the test harness
    /// </summary>
    public class Test
    {
        public static void Main()
        {
            int f; // Factorial result
            bool ok; //Factorial success of failure

            int x; //Input value 1
            //int y; //Input value 2
            //int greater; //Result from Greater()

            //Get input numbers
            //try
            //{
            //    Console.WriteLine("Enter the first number");
            //    x = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter the second number");
            //    y = int.Parse(Console.ReadLine());

            //    //Test the Greater() method
            //    //greater = Utils.Greater(x, y);
            //    //Console.WriteLine("The greater value is " + greater);

            //    //Test the Swap Method
            //    //Console.WriteLine("Before swap: " + x + "," + y);
            //    //Utils.Swap(ref x, ref y);
            //    //Console.WriteLine("After swap: " + x + "," + y);
            //}
            //catch (System.Exception e)
            //{
            //    Console.WriteLine("{0} Exception caught.", e);
            //}
            //Console.ReadKey();

            //Get input for factorial
            try
            {
                Console.WriteLine("Number for factorial: ");
                x = int.Parse(Console.ReadLine());

                //Test the factorial function
                ok = Utils.Factorial(x, out f);

                //Output results
                if (ok)
                {
                    Console.WriteLine("Factorial(" + x + ") = " + f);
                }
                else
                {
                    Console.WriteLine("Cannot compute this factorial");
                }                
            }
            catch (System.Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
            }
            Console.ReadKey();
        }
    }
}