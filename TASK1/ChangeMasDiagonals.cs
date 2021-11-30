using System;

namespace TASK1
{
    public static class ChangeMasDiagonals
    {
        private static readonly int[,] Mas =
        {
            {1,  2,  3,  4,  5},
            {6,  7,  8,  9,  10},
            {11, 12, 13, 14, 15},
            {6,  -7,  8,  -9,  10},
            {-1,  2,  3,  4,  -5}
        };

        private static void ChangeDiagonals()
        {
            for (var i = 0; i <= Mas.GetUpperBound(0); i++)
                for (var j = 0; j <= Mas.GetUpperBound(1); j++)
                {
                    if (i != j) 
                        continue;
                    (Mas[i, j], Mas[i, Mas.GetUpperBound(1) - j]) = (Mas[i, Mas.GetUpperBound(1) - j], Mas[i, j]);
                }
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

        private static void Show()
        {
            Console.WriteLine("Mas with changed diagonals:");
            ShowMas();
        }

        public static void Task13()
        {
            ShowMas();
            ChangeDiagonals();
            Show();
        }
    }
}