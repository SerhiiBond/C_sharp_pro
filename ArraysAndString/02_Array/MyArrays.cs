using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Array
{
    
    class MyArrays
    {
        int[][] myArray;
        int row, line;
        public MyArrays(int line, int row)
        {
            this.row = row;
            this.line = line;
            myArray = new int[line][];
            for (int i = 0; i < line; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    myArray[i] = new int[row];
                }
            }
            CreateArrays();
        }

        private void CreateArrays()
        {
            Random rand = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    myArray[i][j] = rand.Next(10, 99);
                }
            }
        }
        public void ShowArrays()
        {
            for (int i = 0; i < myArray.Length; i++)
            {
                for (int j = 0; j < myArray[i].Length; j++)
                {
                    Console.Write(myArray[i][j]+"  ");
                }
                Console.WriteLine();
            }
        }
    }
}
