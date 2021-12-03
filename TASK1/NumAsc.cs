using System;
using System.Collections.Generic;
using System.Linq;
using static System.Int32;

namespace TASK1
{
    public static class NumAsc
    {
        private static readonly int[] Nums = new int[3];

        private static void Read()
        {
            for (var i = 0; i < 3; i++)
            {
                Console.Write($"{i + 1} number: ");
                
                if (!TryParse(Console.ReadLine(), out Nums[i])) 
                    i--;
            }
        }

        private static List<int> Sort(List<int> nums)
        {
            nums.Sort();
            return nums;
        }

        private static void Show(List<int> nums)
        {
            Console.Write("Sorted numbers: ");
            
            foreach (var n in nums)
                Console.Write(n + " ");
            
            Console.WriteLine();
        }

        public static void Task1()
        {
            Read();
            Show(Sort(Nums.ToList()));
        }
    }
}