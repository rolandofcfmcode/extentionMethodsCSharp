using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXAMPLE 1
            var name = "Rolando";
            var result = name.CharSplitter('#');
            Console.WriteLine("Name with splitter is: " + result);
            Console.ReadLine();

            // EXAMPLE 2
            var person1 = new Person();
            person1.BirthDate = new DateTime(1992, 11, 29);
            person1.Name = "Rolando";
            person1.LastName1 = "Dominguez";
            person1.LastName2 = "Lozano";

            var completeName = person1.GetCompleteName();
            var age = person1.GetCalculatedAge();

            Console.WriteLine("Complete person name is: " + completeName + " and he´s "  + age + " years old");
            Console.ReadLine();
        }
    }
}
