using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    class Program5
    {
        static void Main(string[] args)
        {
            string[] fileArray = Directory.GetDirectories("D:\\pdf");
            Console.WriteLine("The number of directories starting with p is {0}.", fileArray.Length);
            for (int i = 0; i < fileArray.Length; i++)
            {

                //Console.WriteLine(fileArray[i]+"=============================XX");

                string path = fileArray[i];
                DirectoryInfo dir = new DirectoryInfo(path);
                //Console.WriteLine("File Name                       Size        Creation Date and Time");
                Console.WriteLine("=================================================================");
                foreach (FileInfo flInfo in dir.GetFiles())
                {
                    String name = flInfo.Name;
                    long size = flInfo.Length;
                    DateTime creationTime = flInfo.CreationTime;
                    Console.WriteLine("{0, -30:g} {1,-12:N0} {2} ", name, size, creationTime);
                }
            }

            string path1 = "D:\\pdf";
            DirectoryInfo dir1 = new DirectoryInfo(path1);
            //Console.WriteLine("File Name                       Size        Creation Date and Time");
            Console.WriteLine("=================================================================");
            foreach (FileInfo flInfo in dir1.GetFiles())
            {
                String name = flInfo.Name;
                long size = flInfo.Length;
                DateTime creationTime = flInfo.CreationTime;
                Console.WriteLine("{0, -30:g} {1,-12:N0} {2} ", name, size, creationTime);
            }
            Console.ReadLine();
        }

        public void DirectoryFun()
        {
            //FileInfo[] files = DirectoryInfo.GetFiles("*.pdf");

            //foreach (FileInfo file in DirectoryInfo.GetFiles("*.pdf"))
            //{
            //    string contents = File.ReadAllText(file);
            //    Console.WriteLine(contents);
            //}

            //foreach (string file in Directory.EnumerateFiles(@"D:\pdf", " *.pdf"))
            //{
            //    string contents = File.ReadAllText(file);
            //    Console.WriteLine(contents);
            //}
        }

        public class CustomSearcher
        {
            public static List<string> GetDirectories(string path, string searchPattern = "*", SearchOption searchOption = SearchOption.AllDirectories)
            {
                if (searchOption == SearchOption.TopDirectoryOnly)
                    return Directory.GetDirectories(path, searchPattern).ToList();

                var directories = new List<string>(GetDirectories(path, searchPattern));

                for (var i = 0; i < directories.Count; i++)
                    directories.AddRange(GetDirectories(directories[i], searchPattern));

                return directories;
            }

            private static List<string> GetDirectories(string path, string searchPattern)
            {
                try
                {
                    return Directory.GetDirectories(path, searchPattern).ToList();
                }
                catch (UnauthorizedAccessException)
                {
                    return new List<string>();
                }
            }
        }
    }
}
