using System;
using System.Collections.Generic;
using System.Text;

namespace _01_SymbolsInLine
{
    class Handler
    {
        String str;
        public Handler(string str)
        {
            this.str = str;
        }

        public int CountingChar(char ch)
        {
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (ch == str[i])
                {
                    count++;
                }
            }
            return count;
        }
    }
}
