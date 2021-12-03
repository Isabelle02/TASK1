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
            Tools.InputInt("Input lower bound: ", out _lowerBound);
            Tools.InputInt("Input upper bound: ", out _upperBound);
            
            if (_lowerBound > _upperBound) 
                (_lowerBound, _upperBound) = (_upperBound, _lowerBound);
        }
        
        private static int Sum() => Mas.Where(n => n > _lowerBound && n < _upperBound).Sum();

        private static void Show() => Console.Write($"Sum of range from {_lowerBound} to {_upperBound} in mas: {Sum()}");

        public static void Task10()
        {
            Tools.ShowMas(Mas);
            Read();
            Show();
        }
    }
}