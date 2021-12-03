using System;

namespace TASK1
{
    public static class ChangeLetters
    {
        private static string _str;

        private static void Read() => Tools.InputStr("Input string: ", out _str);

        private static string ChangeConE() => _str.Replace("C", "E").Replace("c", "e");

        private static void Show() => Console.WriteLine("String with changed C on E: " + ChangeConE());

        public static void Task17()
        {
            Read();
            Show();
        }
    }
}