using System;
using System.Collections.Generic;
using System.Text;
using static SharpPlayground.Program;

namespace SharpPlayground
{
    internal class Delegates
    {
        // create a method for a delegate
        public static void print(string message)
        {
            Console.WriteLine(message);
        }

        public static void SumOfNumbers(int a, int b, Del callback)
        {
            callback((a + b).ToString());
        }
    }
}
