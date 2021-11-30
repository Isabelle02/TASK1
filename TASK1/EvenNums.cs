using System;
using System.Collections.Generic;
using static System.Int32;

namespace TASK1
{
    public static class EvenNums
    {
        private static int _range;

        private static void Read()
        {
            do Console.Write("Input the range upper bound: ");
            while (!TryParse(Console.ReadLine(), out _range));
        }

        private static List<int> FindEvenNums(int range)
        {
            var evenNums = new List<int>();
            for (var i = 0; i <= range; i++)
                if (i % 2 == 0) evenNums.Add(i);
            
            return evenNums;
        }

        private static void Show(List<int> evenNums)
        {
            Console.Write("Found even numbers: ");
            foreach (var n in evenNums)
                Console.Write(n + " ");
            
            Console.WriteLine();
        }

        public static void Task5()
        {
            Read();
            Show(FindEvenNums(_range));
        }
    }
}