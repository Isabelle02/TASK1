using System;

namespace TASK1
{
    public static class ChangeEvenOddRows
    {
        private static readonly int[,] Mas = new int[4, 4]
        {
            {1, 2, 3, 4}, 
            {8, 7, 6, 5}, 
            {9, 10, 11, 12}, 
            {16, 15, 14, 13}
        };

        private static void ChangeEvenOdd()
        {
            for (var i = 0; i < Mas.GetUpperBound(0); i += 2)
                for (var j = 0; j <= Mas.GetUpperBound(1); j++)
                    (Mas[i, j], Mas[i + 1, j]) = (Mas[i + 1, j], Mas[i, j]);
        }

        private static void ShowMas()
        {
            var i = -1;
            foreach (var n in Mas)
            {
                Console.Write(n + "\t");
                i++;
                if (i != Mas.GetUpperBound(1)) continue;
                Console.WriteLine();
                i = -1;
            }

            Console.WriteLine();
        }

        public static void Task11()
        {
            ShowMas();
            ChangeEvenOdd();
            ShowMas();
        }
    }
}