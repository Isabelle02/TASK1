using System;
using System.Collections.Generic;
using static System.Int32;

namespace TASK1
{
    public static class PerfectNums
    {
        private static int _range;

        private static void Read()
        {
            do Console.Write("Input the range upper bound: ");
            while (!TryParse(Console.ReadLine(), out _range));
        }

        private static List<int> FindPerfectNums(int range)
        {
            var perfectNums = new List<int>();
            var sum = 0;
            
            for (var i = 2; i <= range; i++)
            {
                for (var j = 1; j <= i / 2; j++)
                    if (i % j == 0) 
                        sum += j;
                
                if (sum == i) 
                    perfectNums.Add(i);
                
                sum = 0;
            }
            
            return perfectNums;
        }

        private static void Show(List<int> perfectNums)
        {
            Console.Write("Found perfect numbers: ");
            foreach (var n in perfectNums)
                Console.Write(n + " ");

            Console.WriteLine();
        }

        public static void Task6()
        {
            Read();
            Show(FindPerfectNums(_range));
        }
    }
}