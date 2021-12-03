using System;
using System.Collections.Generic;

namespace TASK1
{
    public static class Tools
    {
        public static void InputInt(string str, out int val)
        {
            do 
                Console.Write(str);
            while (!int.TryParse(Console.ReadLine(), out val));
        }

        public static void InputStr(string str, out string val)
        {
            Console.Write(str);
            val = Console.ReadLine();
        }

        public static void ShowMas(IEnumerable<int> mas)
        {
            foreach (var n in mas)
                Console.Write(n + " ");
            
            Console.WriteLine();
        }

        public static void ShowMas2(int[,] mas)
        {
            for (var i = 0; i <= mas.GetUpperBound(0); i++)
            {
                for (var j = 0; j <= mas.GetUpperBound(1); j++)
                    Console.Write(mas[i, j] + "\t");
                
                Console.WriteLine();
            }
        }
    }
}