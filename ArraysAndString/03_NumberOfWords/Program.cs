/*Задача 3. В заданной строке текста определите количество слов. Каждое слово отделено друг от друга пробелом.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_NumberOfWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = " В заданной строке текста определите количество слов. ";
            //str = str.Trim(new Char[] { ' '});
            Console.WriteLine(str);
            //string[] split = str.Split(new Char[] { ' ' });
            string[] split = str.Trim(new Char[] { ' ' }).Split(new Char[] { ' ' });
            Console.WriteLine("Количество слов в строке: {0}", split.Length);

            foreach (string item in split)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
