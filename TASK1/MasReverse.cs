﻿using System;

namespace TASK1
{
    public static class MasReverse
    {
        private static readonly int[] Mas = {0, 1, 2, 3, 4, 5, 6};

        private static void Reverse()
        {
            for (var i = 0; i < Mas.Length / 2; i++)
                (Mas[i], Mas[^(i + 1)]) = (Mas[^(i + 1)], Mas[i]);
        }
        
        private static void ShowMas()
        {
            foreach (var n in Mas)
                Console.Write(n + " ");
            
            Console.WriteLine();
        }

        private static void Show()
        {
            Console.Write("Reversed mas: ");
            ShowMas();
        }

        public static void Task9()
        {
            ShowMas();
            Reverse();
            Show();
        }
    }
}