using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingParams
{
    internal class MainApp
    {
        static int Sum(params int[] args)
        {
            Console.Write("Summing... ");
            int sum = 0;

            for(int i=0; i<args.Length; i++)
            {
                if(i>0)
                    Console.Write(", ");

                Console.Write(args[i]);
                sum += args[i];
            }
            Console.WriteLine();

            return sum;
        }
        static void Main(string[] args)
        {
            int sum = Sum(3, 5, 1, 58, 7, 41, 2, 5, 47, 1, 5, 5);
            Console.WriteLine($"sum : {sum}");
        }
    }
}
