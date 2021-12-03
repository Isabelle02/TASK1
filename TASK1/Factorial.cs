using System;
using static System.Int32;

namespace TASK1
{
    public static class Factorial
    {
        private static int _num;

        private static void Read()
        {
            do 
                Tools.InputInt("Input number: ", out _num);
            while (_num < 0);
        }

        private static int FindFactorial(int num)
        {
            var n = 1;
            
            for (var i = 2; i <= num; i++)
                n *= i;

            return n;
        }

        private static void Show() => Console.WriteLine("Found factorial: " + FindFactorial(_num));

        public static void Task3()
        {
            Read();
            Show();
        }
    }
}