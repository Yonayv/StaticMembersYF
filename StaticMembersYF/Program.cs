using System;

namespace StaticMembersYF
{
    class Program
    {
        /// <summary>
        /// Int methods heading is printed console
        /// console for calculating add, sub mult, & div executes each integer arguments
        /// Floats methods heading is printed to console
        /// the floating point number arguments are printed to the console.
        /// </summary>
        /// <param name="args"></param>
        /// 
        static void Main(string[] args)
        {
            //Integers
            Console.WriteLine("Interger Methods");
            Console.WriteLine("15 is 88 is" + Calculate.Add(15, 88));
            Console.WriteLine(Calculate.Sub(78, 88));
            Console.WriteLine(Calculate.Mult(8, 9));
            Console.WriteLine(Calculate.Div(77, 8));

            //Floats
            Console.WriteLine("\nFloat Methods");
            Console.WriteLine(Calculate.Add(15.55f, 88.65f));
            Console.WriteLine(Calculate.Sub(78.45f, 88.89f));
            Console.WriteLine(Calculate.Mult(8.99f, 9.65f));
            Console.WriteLine(Calculate.Div(77.265f, 8.0f));

        }
    }
}
