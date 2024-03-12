using System;

namespace String
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            string a = "안녕하세요?";
            string b = "김민규입니다.";

            string multiline = "첫 번째 줄 \n 두 번째 줄 \n 세 번째 줄";
            string multilines = """
                첫 번째줄에 이어서
                두 번째 줄에 이어서
                세 번째 줄까지
                """;

            Console.WriteLine(multilines);

            Console.WriteLine(multiline);

            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
