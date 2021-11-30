using System;
using System.Linq;

namespace TASK1
{
    public static class AmountStartK
    {
        private static string _str;

        private static void Read()
        {
            Console.Write("Input string: ");
            _str = Console.ReadLine();
        }

        private static int CountStartK()
        {
            return _str.Where((t, i) => t is 'K' or 'k' && (i == 0 || _str[i - 1] == ' ')).Count();
        }

        private static void Show()
        {
            Console.WriteLine("Amount of words starting with K: " + CountStartK());
        }

        public static void Task18()
        {
            Read();
            Show();
        }
    }
}