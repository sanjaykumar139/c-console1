using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program4
    {
        static void Main4(string[] args)
        {
            var person = GetPerson();

            Console.WriteLine($"Id = { person.Item1}");
            Console.WriteLine($"First Name = { person.Item2}");
            Console.WriteLine($"Last Name = { person.Item3}");

            var person1 = GetPerson1();
            Console.WriteLine($"Id = { person1.Item1}");
            Console.WriteLine($"First Name = { person1.Item2}");
        }

        static Tuple<int, string, string> GetPerson()
        {
            return Tuple.Create(1, "Bill", "Gates");
        }

        static Tuple<bool, string> GetPerson1()
        {
            bool result1 = false;
            string result = "";

            if (4 / 2 == 0)
            {
                result = "even";
                result1 = true;
            }
            else
                result = "odd";

            return Tuple.Create(result1,result);
        }
    }
}
