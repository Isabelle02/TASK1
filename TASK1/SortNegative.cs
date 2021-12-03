using System;
using System.Collections.Generic;
using System.Linq;

namespace TASK1
{
    public static class SortNegative
    {
        private static readonly int[] Mas = {0, -1, 2, -2, 3, -5, -4};

        private static void SortNegativeNums()
        {
            var mas = Mas.Where(t => t < 0).ToList();
            mas.Sort();
            var j = 0;
            
            for (var i = 0; i < Mas.Length; i++)
            {
                if (Mas[i] >= 0) 
                    continue;
                
                Mas[i] = mas[j];
                j++;
            }
        }

        private static void Show()
        {
            Console.Write("Sorted negative numbers in mas: ");
            Tools.ShowMas(Mas);
        }

        public static void Task8()
        {
            Tools.ShowMas(Mas);
            SortNegativeNums();
            Show();
        }
    }
}