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

        private static void Show()
        {
            Console.WriteLine("Mas with changed diagonals:");
            Tools.ShowMas2(Mas);
        }

        public static void Task13()
        {
            Tools.ShowMas2(Mas);
            ChangeDiagonals();
            Show();
        }
    }
}