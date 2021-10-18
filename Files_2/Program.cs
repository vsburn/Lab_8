using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathFolder = "Log";
            string pathFile = "Log/Log.txt";
            if (!Directory.Exists(pathFolder))
            {
                Directory.CreateDirectory(pathFolder);
            }
            if (!File.Exists(pathFile))
            {
                File.Create(pathFile);
            }
            using (StreamWriter sw = new StreamWriter(pathFile, false))
            {
                Random random = new Random();
                for (int i = 0; i < 10; i++)
                {
                    sw.WriteLine(random.Next(100));
                }
            }
            int sum = 0;
            using (StreamReader sr = new StreamReader(pathFile))
            {
                for (int i = 0; i < 10; i++)
                {
                    sum += Convert.ToInt32(sr.ReadLine());
                }
            }
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
