/*Задача 2. Задан массив действительных чисел размерности 10х10.
 Найти суммы элементов каждой строки, произведения элементов каждого столбца, 
 и максимальный элемент главной диагонали(подсказка: все элементы, для которых номер строки совпадает с номером столбца).*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            int line;
            int row;
            Console.Write("Введите количество строк в массиве: ");
            line = Convert.ToInt16(Console.ReadLine());
            Console.Write("Введите количество столбцов в массиве: ");
            row = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine(new String('-',100));
            MyArrays array = new MyArrays(line, row);
            array.ShowArrays();
            Console.WriteLine(new String('-', 100));

            //Поиск суммы каждой строки
            int sum;
            for (int i = 0; i < array.NumberOfLines(); i++)
            {
                sum = 0;
                for (int j = 0; j < array.NumberOfRows(); j++)
                {
                    sum += array[i,j];
                }
                Console.WriteLine("Сумма элементов строки №{0}: {1}",i,sum);
            }
            Console.WriteLine(new String('-', 100));

            //Произведение элементов каждого столбца
            Int64 mult;
            for (int j = 0; j < array.NumberOfRows(); j++)
            {
                mult = 1;
                for (int i = 0; i < array.NumberOfLines(); i++)
                {
                    mult *= array[i, j];
                }
                Console.WriteLine("Произведение элементов столбца №{0}: {1}", j, mult);
            }
            Console.WriteLine(new String('-', 100));

            //Максимальный элемент главной диагонали
            int maxElement = array[0, 0];
            int coordinate = 0;
            for (int i = 1; i < array.NumberOfLines(); i++)
            {
                if (maxElement < array[i, i])
                {
                    maxElement = array[i, i];
                    coordinate = i;
                }
            }
            Console.WriteLine("Максимальный элемент главной диагонали : {0},  его коокдинаты ({1},{1})", maxElement, coordinate);
            Console.ReadKey();
        }
    }
}
