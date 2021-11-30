using System;
using System.Linq;
using static System.Int32;

namespace TASK1
{
    public static class SumRange
    {
        private static int _lowerBound;
        private static int _upperBound;
        private static readonly int[] Mas = {0, 2, 3, 5, 4, 6, 2, 7};

        private static void Read()
        {
            do Console.Write("Input lower bound: ");
            while (!TryParse(Console.ReadLine(), out _lowerBound));
            
            do Console.Write("Input upper bound: ");
            while (!TryParse(Console.ReadLine(), out _upperBound));
            
            if (_lowerBound > _upperBound) 
                (_lowerBound, _upperBound) = (_upperBound, _lowerBound);
        }
        
        private static int Sum()
        {
            return Mas.Where(n => n > _lowerBound && n < _upperBound).Sum();
        }
        
        private static void ShowMas()
        {
            foreach (var n in Mas)
                Console.Write(n + " ");
            
            Console.WriteLine();
        }

        private static void Show(int sum)
        {
            Console.Write($"Sum of range from {_lowerBound} to {_upperBound} in mas: {sum}");
        }

        public static void Task10()
        {
            ShowMas();
            Read();
            Show(Sum());
        }
    }
}