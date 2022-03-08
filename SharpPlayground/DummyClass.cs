using System;
using System.Collections.Generic;
using System.Text;

namespace SharpPlayground
{
    internal class DummyClass
    {
        public void P1(string message) {
        Console.WriteLine($"Aaaaa I'm the first dummy method...what should I do with: {message}");
        }
        public void P2(string message) {
            Console.WriteLine($"Ooooo no, I received a message: {message}");
        }
    }
}
