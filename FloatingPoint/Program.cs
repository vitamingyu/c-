using System;

namespace FloatingPoint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a = 3.1415_926535897932f;
            Console.WriteLine(a);

            double b = 3.1415_92653589_7932;
            Console.WriteLine(b);
        }
    }
}
