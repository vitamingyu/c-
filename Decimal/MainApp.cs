using System;

namespace Decimal
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            float a = 3.1415_9265_3589_7932_3846_2643_3832f;
            double b = 3.1415_9265_3589_7932_3846_2643_3832;
            decimal c = 3.1415_9265_3589_7932_3846_2643_3832m;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

        }
    }
}
