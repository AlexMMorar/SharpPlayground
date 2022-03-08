using System;

namespace SharpPlayground
{
    class Program
    {
        //define a delegate!
        public delegate void Del(string message);

        static void Main(string[] args)
        {

            // Instantiate the delegate.
            Del myDelegate = Delegates.print;

            // Call the delegate.
            myDelegate("Hello World!");

            //using the delegate as an callback -> see implementation.
            Delegates.SumOfNumbers(5, 7, myDelegate);



            Console.WriteLine("\n------------ Combined Delegates ------------\n");
            //combining delegates
            var obj = new DummyClass();
            Del d1 = obj.P1;
            Del d2 = obj.P2;
            Del d3 = Delegates.print;

            //now we will create another delegate to combine the delegates declared above
            Del combinedDelegates = d1 + d2;
            combinedDelegates += d3;

            //lets see what happens if we invoke the combined delegaates.

            Delegates.SumOfNumbers(21, 21, combinedDelegates);

            Console.WriteLine($"The length of our list of delegates is: {combinedDelegates.GetInvocationList().Length}");


            Console.WriteLine("\n------------> Remove delegate");
            combinedDelegates -= d1;
            Delegates.SumOfNumbers(2, 2, combinedDelegates);

             Console.WriteLine("\n------------> Compare delegates");
             if (d1 == d2)
             {
                 Console.WriteLine("They are equal");
             }
             else
             {
                 Console.WriteLine("They are not");
             }

             Console.WriteLine("\n-----------> Declare delegates as lambda!");
             Del del4 = name => { Console.WriteLine($"Lecture recommanded from: {name}"); };

             del4("Sergiu");
        }
    }
}
