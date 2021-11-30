using System;
using System.Linq;

namespace TASK1
{
    public static class SumEvenOddPos
    {
        private static readonly int[] Mas = {0, 1, 2, 3, 4, 5, 6};

        private static int SumOddPos()
        {
            return Mas.Where((t, i) => i % 2 != 0).Sum();
        }

        private static int SumEvenPos()
        {
            return Mas.Where((t, i) => i % 2 == 0).Sum();
        }

        private static void ShowMas()
        {
            foreach (var n in Mas)
                Console.Write(n + " ");
            
            Console.WriteLine();
        }
        
        private static void Show()
        {
            Console.WriteLine("Numbers sum at the odd position: " + SumOddPos());
            Console.WriteLine("Numbers sum at the even position: " + SumEvenPos());
        }

        public static void Task7()
        {
            ShowMas();
            Show();
        }
    }
}