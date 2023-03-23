using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program2
    {
        public static string Burning = "merchant/redemption/cashback";
        public const string Retrieve = "merchant/customer/search/mobile/{0}?extendedParams=referralCode";
        public const string TransactionHistory = "merchant/customer/transactions/{0}/{1}/{2}?page.page=1&page.size=100";

        static void Main2(string[] args)
        {
            string name = "abc";
            //Console.WriteLine(Retrieve,"5");

            //Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", "name", "date.DayOfWeek", "date");

            string template = "Hi We have these flights for you: {0}. Which one do you want";
            string data = "A, B, C, D";
            string message = string.Format(template, data);

            string message1 = string.Format(TransactionHistory, name,data,"abaaaaaaaa");

            Console.WriteLine(message1);
        }
    }
}

