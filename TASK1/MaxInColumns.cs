using System;
using System.Collections.Generic;

namespace TASK1
{
    public static class MaxInColumns
    {
        private static readonly int[,] Mas = {{-1, 0, 23}, {-3, -12, 4}, {12, 100, -3}};

        private static List<int> MaxColumns()
        {
            var maxNums = new List<int>();
            var maxNum = Mas[0, 0];
            
            for (var j = 0; j <= Mas.GetUpperBound(1); j++)
            {
                for (var i = 0; i <= Mas.GetUpperBound(0); i++)
                    if (maxNum < Mas[i, j]) 
                        maxNum = Mas[i, j];
                
                maxNums.Add(maxNum);
                maxNum = Mas[0, j];
            }
            
            return maxNums;
        }
        
        private static void ShowMas()
        {
            var i = -1;
            foreach (var n in Mas)
            {
                Console.Write(n + "\t");
                i++;
                if (i != Mas.GetUpperBound(1)) 
                    continue;
                
                Console.WriteLine();
                i = -1;
            }

            Console.WriteLine();
        }

        private static void Show()
        {
            var maxColumns = MaxColumns();
            
            for (var i = 0; i < maxColumns.Count; i++)
                Console.WriteLine($"{i} column: max number {maxColumns[i]}");
        }

        public static void Task12()
        {
            ShowMas();
            Show();
        }
    }
}