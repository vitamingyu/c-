using System;
using static System.Console;

namespace Hello
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            if ( args.Length == 0)
            {
                Console.WriteLine("여러분, 안녕하세요? \n반갑습니다!");
                return;
            }

            WriteLine("Hello, {0}", args[0]);
    
        }
    }
}
