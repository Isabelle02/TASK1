using System;
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

        private static int[] Sort(int[] nums)
        {
            for (var i = 0; i < nums.Length - 1; i++)
                for (var j = i + 1; j < nums.Length; j++)
                    if (nums[i] > nums[j]) 
                        (nums[i], nums[j]) = (nums[j], nums[i]);

            return nums;
        }

        private static void Show(int[] nums)
        {
            Console.Write("Sorted numbers: ");
            foreach (var n in nums)
                Console.Write(n + " ");
            
            Console.WriteLine();
        }

        public static void Task1()
        {
            Read();
            Show(Sort(Nums));
        }
    }
}