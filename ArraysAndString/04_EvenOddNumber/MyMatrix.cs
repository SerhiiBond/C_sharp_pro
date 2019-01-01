using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_EvenOddNumber
{
    class MyMatrix
    {
        Random rand = new Random();
        int[] arr;
        public MyMatrix(int length)
        {
            arr = new int[length];
            for (int i = 0; i < arr.Length; i++)
            {
               arr[i] = rand.Next(10, 99);
            }
        }

        public int this[int index]
        {
            get { return arr[index]; }
        }

        public int NumberOfElement()
        {
            return arr.Length;
        }
        
        public void Show()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine(););
        }
        public void SortArr()
        {
            int tmp = ;
            for (int i = 0; i < arr.Length; i++)
            {
                tmp = arr[i];
                for (int j = 0; j < arr.Length; j++)
                {

                }
            }
        }
    }
}
