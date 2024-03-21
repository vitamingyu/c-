using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamedParameter
{
    internal class MainApp
    {
        static void PrinProfile(string name, string phone)
        {
            Console.WriteLine($"Name : {name}, Phone:{phone}");
        }

        static void Main(string[] args)
        {
            PrinProfile(name: "박찬호", phone: "010-1234-1234");
            PrinProfile(phone: "010-1234-4313", name: "김광자");
            PrinProfile("박세리", "010-4252-2342");
            PrinProfile("박상현", phone: "010-4532-5234");
        }
    }
}
