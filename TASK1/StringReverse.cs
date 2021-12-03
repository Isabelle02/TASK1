using System;
using System.Linq;

namespace TASK1
{
    public static class StringReverse
    {
        private static string _str;

        private static void Read() => Tools.InputStr("Input string: ", out _str);

        private static string Reverse(string str) => (string) str.Reverse();

        private static void Show(string reversedStr) => Console.WriteLine("Reversed string: " + reversedStr);

        public static void Task16()
        {
            Read();
            Show(Reverse(_str));
        }
    }
}