using System;

namespace RecordsVsClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1Record = new EmployeeRecord("Alex", "Morar", "SM");
            var person2Record = new EmployeeRecord("Alex", "Morar", "SM");

            var compareRecord = person1Record == person2Record ? "Are equal" : "Are not equal";
            Console.WriteLine("---------Record equality---------");
            Console.WriteLine();
            Console.WriteLine("Record display using ToString()");
            Console.WriteLine($"{person1Record.ToString()}");
            Console.WriteLine($"{person2Record.ToString()}");
            Console.WriteLine($"{compareRecord}");
            Console.WriteLine();

            //Copy record and modify properties
            var person3Record = person1Record with { FirstName = "Vlad", LastName = "Vesa" };

            compareRecord = person1Record == person3Record ? "Are equal" : "Are not equal";
            Console.WriteLine();
            Console.WriteLine($"Old record: {person1Record.ToString()}");
            Console.WriteLine($"New copy record: {person3Record.ToString()}");
            Console.WriteLine($"{compareRecord}");
            Console.WriteLine();

            var person1Class = new EmployeeClass("Vlad", "Vesa", "Dev");
            var person2Class = new EmployeeClass("Vlad", "Vesa", "Dev");

            var compareClass = person1Class == person2Class ? "Are equal" : "Are not equal";
            Console.WriteLine("---------Class equality---------");
            Console.WriteLine();
            Console.WriteLine("Class display using ToString()");
            Console.WriteLine($"{person1Class.ToString()}");
            Console.WriteLine($"{person2Class.ToString()}");
            Console.WriteLine();
            Console.WriteLine($"Person1: {person1Class.FirstName}, {person1Class.LastName}, {person1Class.Job}");
            Console.WriteLine($"Person2: {person2Class.FirstName}, {person2Class.LastName}, {person2Class.Job}");
            Console.WriteLine($"{compareClass}");
            Console.WriteLine();

            var person3Class = person1Class;
            person3Class.FirstName = "Alex";
            person3Class.LastName = "Morar";

            compareClass = person1Class == person3Class ? "Are equal" : "Are not equal";
            Console.WriteLine();
            Console.WriteLine($"Person1: {person1Class.FirstName}, {person1Class.LastName}, {person1Class.Job}");
            Console.WriteLine($"Person3: {person3Class.FirstName}, {person3Class.LastName}, {person3Class.Job}");
            Console.WriteLine($"{compareClass}");
            Console.WriteLine();
        }
    }
}
