using System;
using MyExtension;

namespace MyExtension
{
    public static class StringExtension
    {
        public static string Append(this string sr, string sr2)
        {
            return sr + sr2;
        }
    }
}


namespace ExtensionMethod
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            Console.WriteLine(hello.Append(", World!"));
        }
    }
}
