using System;
using System.Threading;

namespace Les1TijdOpHetScherm
{
    class Program
    {
        static void Main(string[] args)
        {
            int colorCounter = 0;
            int colorIndex = 0;

            ConsoleColor[] colors = {ConsoleColor.Red, ConsoleColor.Cyan, ConsoleColor.Blue, ConsoleColor.Green, ConsoleColor.Yellow};

            while(true)
            {
                DateTime date = DateTime.Now;

                //Console.Clear();
                Console.Write("\r" + date.ToString("HH::mm:ss"));

                Thread.Sleep(1000);
                colorCounter++;
                if(colorCounter >= 10)
                {
                    colorCounter = 0;

                    Console.ForegroundColor = colors[colorIndex];

                    colorIndex++;
                    if (colorIndex >= colors.Length) colorIndex = 0;
                }
            }
        }
    }
}
