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
            do Console.Write("Input amount of numbers: ");
            while (!TryParse(Console.ReadLine(), out _amount) || _amount < 0);
            
            do Console.Write("Input start number: ");
            while (!TryParse(Console.ReadLine(), out _startNum));
            
            do Console.Write("Input step: ");
            while (!TryParse(Console.ReadLine(), out _step));
        }

        private static int FindSum(int amount, int startNum, int step)
        {
            var sum = 0;
            while (amount != 0)
            {
                sum += startNum;
                startNum += step;
                amount--;
            }

            return sum;
        }

        private static void Show(int foundSum)
        {
            Console.WriteLine($"Sum of {_amount} numbers from start number {_startNum} with step {_step}: {foundSum}");
        }

        public static void Task4()
        {
            Read();
            Show(FindSum(_amount, _startNum, _step));
        }
    }
}