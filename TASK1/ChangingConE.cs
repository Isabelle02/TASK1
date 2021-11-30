using System;

namespace TASK1
{
    public static class ChangingConE
    {
        private static string _str;

        private static void Read()
        {
            Console.Write("Input string: ");
            _str = Console.ReadLine();
        }

        private static void ChangeConE()
        {
            _str = _str.Replace("C", "E").Replace("c", "e");
        }

        private static void Show()
        {
            Console.WriteLine("String with changed C on E: " + _str);
        }

        public static void Task17()
        {
            Read();
            ChangeConE();
            Show();
        }
    }
}