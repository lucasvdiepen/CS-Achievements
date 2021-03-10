using System;

namespace Les5Scopes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Scope();
        }

        private static void Scope()
        {

            for(int i = 0; i < 10; i++)
            {
                string nieuweVariable = "Nieuwe variable";

                if(i == 7)
                {
                    Console.WriteLine("i = " + i);
                }
            }
        }
    }
}
