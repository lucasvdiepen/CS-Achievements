using System;

namespace Les1FunctiesReturn
{
    class Program
    {
        static void Main(string[] args)
        {
            //Run the function 10 times
            for(int i = 0; i<10; i++)
            {
                Console.WriteLine(GetRandomNumber());
            }
        }

        private static int GetRandomNumber()
        {
            Random rnd = new Random();
            return rnd.Next(1, 21);
        }
    }
}
