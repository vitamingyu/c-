﻿using System;
using static System.Console;

namespace StringSlice
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            string greeting = "Good morning.";

            WriteLine(greeting.Substring(0,5));  //Good
            WriteLine(greeting.Substring(5)); // 5부터 끝까지

            WriteLine();

            string[] arr = greeting.Split(
                new string[] { " " }, StringSplitOptions.None);
            WriteLine("Word Count : {0}", arr.Length);

            foreach (string element in arr)
                WriteLine("{0}", element);
        }
    }
}
