using System;
using System.Collections.Generic;

namespace TASK1
{
    public static class MaxInColumns
    {
        private static readonly int[,] Mas =
        {
            {-1, 0, 23}, 
            {-3, -12, 4}, 
            {12, 100, -3}
        };

        private static List<int> MaxColumns()
        {
            var maxNums = new List<int>();

            for (var j = 0; j <= Mas.GetUpperBound(1); j++)
            {
                var maxNum = Mas[0, j];
                
                for (var i = 0; i <= Mas.GetUpperBound(0); i++)
                    if (maxNum < Mas[i, j]) 
                        maxNum = Mas[i, j];

                maxNums.Add(maxNum);
            }
            
            return maxNums;
        }

        private static void Show()
        {
            var maxColumns = MaxColumns();
            
            for (var i = 0; i < maxColumns.Count; i++)
                Console.WriteLine($"{i + 1} column: max number {maxColumns[i]}");
        }

        public static void Task12()
        {
            Tools.ShowMas2(Mas);
            Show();
        }
    }
}