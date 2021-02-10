using System;

namespace Les1Functies
{
    class Program
    {
        static void Main(string[] args)
        {
            FlipString("Hello World!");
        }

        private static void FlipString(string text)
        {
            char[] chars = text.ToCharArray();
            Array.Reverse(chars);
            Console.WriteLine(new string(chars));
        }
    }
}
