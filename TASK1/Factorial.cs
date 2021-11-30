using System;
using static System.Int32;

namespace TASK1
{
    public static class Factorial
    {
        private static int _num;

        private static void Read()
        {
            do Console.Write("Input number: ");
            while (!TryParse(Console.ReadLine(), out _num) || _num < 0);
        }

        private static int FindFactorial(int num)
        {
            var n = 1;
            for (var i = 1; i <= num; i++)
                n *= i;

            return n;
        }

        private static void Show(int foundFactorial)
        {
            Console.WriteLine("Found factorial: " + foundFactorial);
        }

        public static void Task3()
        {
            Read();
            Show(FindFactorial(_num));
        }
    }
}