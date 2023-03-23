using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program3
    {
        static void Main3(string[] args)
        {
            //Console.WriteLine("Hello World!");

            const string filePath = @"C:\temp\Loyalty";





            DirectoryInfo d = new DirectoryInfo(@"C:\temp\Loyalty"); //Assuming Test is your Folder
            FileInfo[] Files = d.GetFiles("*.json"); //Getting Text files
            string str = "";

            foreach (FileInfo file in Files)
            {
                str = str + ", " + file.Name;
            }
            Console.WriteLine(str+ "\n==============================\n");

            Display();

        }

        static void Display()
        {
            string filePath = @"C:\temp\Loyalty\" + "log-20220401.json";
            string fileData = "";
            //string filePath1 = System.IO.Path.Combine(_webHostEnvironment.ContentRootPath, "errorcode.json");

            if (System.IO.File.Exists(filePath))
            {
                fileData = System.IO.File.ReadAllText(filePath);
            }
            Console.WriteLine(fileData);
        }
    }
}