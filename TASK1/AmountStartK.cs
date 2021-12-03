using System;
using System.Linq;

namespace TASK1
{
    public static class AmountStartK
    {
        private static string _str;

        private static void Read() => Tools.InputStr("Input string: ", out _str);

        private static int CountStartK() => _str.Where((t, i) => t is 'K' or 'k' && (i == 0 || _str[i - 1] == ' ')).Count();

        private static void Show() => Console.WriteLine("Amount of words starting with K: " + CountStartK());

        public static void Task18()
        {
            Read();
            Show();
        }
    }
}