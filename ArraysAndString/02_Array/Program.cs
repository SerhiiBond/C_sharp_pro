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
            MyArrays array = new MyArrays(10, 10);
            array.ShowArrays();

            Console.ReadKey();
        }
    }
}
