using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMembersYF
{

    /// <summary>
    /// Static class Calculate implements a static contstructor
    /// Public static float was created with a result of = 0.0f
    /// The static Calculate initialiesz the result value to '0.0f'
    /// Public methods were created to add, sub, mult, & div two int numbers together and return the result
    /// An overload method was made for two floating point numbers and return the results
    /// </summary>
    static class Calculate
    {

        public static float result = 0.0f;

        static Calculate()
        {
            result = 0.0f;
        }

        // INT
        public static int Add(int x, int y)
        {
            return x + y;
        }

        public static int Sub(int x, int y)
        {
            return x - y;
        }

        public static int Mult(int x, int y)
        {
            return x * y;
        }

        public static int Div(int x, int y)
        {
            return x / y;
        }

        // FLOATING
        public static float Add(float x, float y)
        {
            return x + y;
        }
        public static float Sub(float x, float y)
        {
            return x - y;
        }

        public static float Mult(float x, float y)
        {
            return x * y;
        }

        public static float Div(float x, float y)
        {
            return x / y;
        }
    }
}
