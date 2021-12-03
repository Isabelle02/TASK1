using System;
using static System.Int32;

namespace TASK1
{
    public static class SumStartNum
    {
        private static int _amount;
        private static int _startNum;
        private static int _step;

        private static void Read()
        {
            do 
                Tools.InputInt("Input amount of numbers: ", out _amount);
            while (_amount < 0);
            
            Tools.InputInt("Input start number: ", out _startNum);
            
            Tools.InputInt("Input step: ", out _step);
        }

        private static int FindSum()
        {
            var sum = 0;
            
            while (_amount != 0)
            {
                sum += _startNum;
                _startNum += _step;
                _amount--;
            }

            return sum;
        }

        private static void Show(int foundSum) => Console.WriteLine($"Sum of {_amount} numbers from start number {_startNum} with step {_step}: {foundSum}");

        public static void Task4()
        {
            Read();
            Show(FindSum());
        }
    }
}