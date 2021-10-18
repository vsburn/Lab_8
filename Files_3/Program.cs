using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathTxt = "C:/test/text3.txt";
            string txt;
            using (StreamReader sr = new StreamReader(pathTxt))
            {
                txt = sr.ReadToEnd();
            }
            string txt2 ="";
            int sumStr = 1, sumWrd = 0;
            foreach (char a in txt)
            {
                sumStr = (a == '\n') ? ++sumStr : sumStr; // подсчет количества строк
                if (!Char.IsPunctuation(a)) // отбрасывание знаков препинания
                {
                    if (Char.IsSeparator(a)) // приведение всех знаков разделителей к символу пробела
                    {
                        txt2 += ' ';
                    }
                    else
                    {
                        txt2 += a;
                    }
                }
            }
            string[] arrTxt = txt2.Split(' ', '\n');
            foreach (string s in arrTxt)
            {
                bool f = false;
                foreach (char c in s)
                {
                    if (Char.IsLetter(c))
                    {
                        f = true;
                    }
                }
                sumWrd = (f) ? ++sumWrd : sumWrd;
            }
            Console.WriteLine("Количество символов: {0}", txt.Length);
            Console.WriteLine("Количество строк: {0}", sumStr);
            Console.WriteLine("Количестов слов: {0}", sumWrd);
            Console.ReadKey();
        }
    }
}
