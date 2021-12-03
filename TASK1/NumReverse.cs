using System;
using System.Linq;
using static System.Int32;
using static System.Math;

namespace TASK1
{
    public static class NumReverse
    {
        private static int _num;

        private static void Read() => Tools.InputInt("Input number: ", out _num);

        private static int Reverse(int num)
        {
            var val = Abs(num).ToString();
            val = (string) val.Reverse();
            
            if (num < 0) 
                val = "-" + val;
            
            num = Parse(val);
            
            return num;
        }

        private static void Show(int reversedNum) => Console.WriteLine("Reversed number: " + reversedNum);

        public static void Task2()
        {
            Read();
            Show(Reverse(_num));
        }
    }
}