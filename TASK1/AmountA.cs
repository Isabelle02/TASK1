using System;
using System.Linq;

namespace TASK1
{
    public static class AmountA
    {
        private static string _str;

        private static void Read()
        {
            Console.Write("Input string: ");
            _str = Console.ReadLine();
        }

        private static int CountA()
        {
            return _str.Count(s => s is 'A' or 'a');
        }

        private static void Show()
        {
            Console.WriteLine($"Amount of A in \"{_str}\": {CountA()}");
        }

        public static void Task14()
        {
            Read();
            Show();
        }
    }
}