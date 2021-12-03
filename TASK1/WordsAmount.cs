using System;

namespace TASK1
{
    public static class WordsAmount
    {
        private static string _str;

        private static void Read() => Tools.InputStr("Input string: ", out _str);

        private static int CountWords()
        {
            var words = _str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            return words.Length;
        }

        private static void Show() => Console.WriteLine("Amount of words: " + CountWords());

        public static void Task15()
        {
            Read();
            Show();
        }
    }
}