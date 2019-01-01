/*Задача 1. Введите с клавиатуры строку произвольной длины и подсчитайте процент вхождения заданного символа в строку.*/
using System;

namespace _01_SymbolsInLine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string str = Console.ReadLine();
            Console.WriteLine(new String('-',100));
            Console.WriteLine("Вы ввели: {0}",str);

            Console.Write("Введите символ, который нужно найти:");
            char ch = Convert.ToChar(Console.ReadLine());
            Handler handler = new Handler(str);
            int count = handler.CountingChar(ch);
            if (count != 0)
            {
                Console.WriteLine("Символ {0} в данной строке повторяется {1} раз", ch, count);
            }
            else
            {
                Console.WriteLine("Символа {0} в данной строке нет", ch, count);
            }
           
           
            Console.ReadKey();
        }
    }
}
