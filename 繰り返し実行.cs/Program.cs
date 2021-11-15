using System;

namespace 繰り返し実行.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Enumerable.Range(0, 4);

            foreach (var item in Enumerable.Range(1, 2))
                Console.WriteLine("I am a cat.");
        }
    }
}
