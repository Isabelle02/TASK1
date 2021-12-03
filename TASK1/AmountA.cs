using System;
using System.Linq;

namespace TASK1
{
    public static class AmountA
    {
        private static string _str;

        private static void Read() => Tools.InputStr("Input string: ", out _str);

        private static int CountA() => _str.Count(s => s is 'A' or 'a');

        private static void Show() => Console.WriteLine($"Amount of A in \"{_str}\": {CountA()}");

        public static void Task14()
        {
            Read();
            Show();
        }
    }
}