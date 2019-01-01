/*Задача 4. Задан одномерный массив целых чисел. 
 Образуйте из него два отсортированных по возрастанию массива, 
 содержащих четные и нечетные числа. Подсказка: четное число делится на 2 без остатка.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_EvenOddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов массива: ");
            int n = Convert.ToInt16(Console.ReadLine());

            MyMatrix arr = new MyMatrix(n);
            arr.Show();
            Console.WriteLine(new string('-',100));

            Console.ReadKey();
        }
    }
}
