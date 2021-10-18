using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirName = @"C:\Program Files (x86)\Microsoft.NET";
            GetDir(dirName);
            Console.ReadKey();
        }


        static void GetDir(string path)
        {
            string[] files = Directory.GetFiles(path);
            foreach (string f in files)
            {
                Console.WriteLine(f);
            }
            Console.WriteLine();
            string[] dirs = Directory.GetDirectories(path);
            foreach (string d in dirs)
            {
                Console.WriteLine(d);
                GetDir(d);
            }
        }
    }
}
