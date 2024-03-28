using System;

namespace ArraySample
{
    class MainApp
    {
        static void Main(string[] args)
        {
            int[] scores = new int[5];
            scores[0] = 1;
            scores[1] = 2;
            scores[2] = 3;
            scores[^2] = 4;
            scores[^1] = 5;

            foreach(int score in scores)
                Console.WriteLine(score);

            int sum = 0;
            foreach(int score in scores)
                sum += score;

            int average = sum / scores.Length;

            Console.WriteLine($"Average Score : {average}");
        }
    }
}