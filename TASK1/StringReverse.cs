using System;
using System.Linq;

namespace TASK1
{
    public static class StringReverse
    {
        private static string _str;

        private static void Read()
        {
            Console.Write("Input string: ");
            _str = Console.ReadLine();
        }

        private static string Reverse(string str)
        {
            return (string) str.Reverse();
        }

        private static void Show(string reversedStr)
        {
            Console.WriteLine("Reversed string: " + reversedStr);
        }

        public static void Task16()
        {
            Read();
            Show(Reverse(_str));
        }
    }
}