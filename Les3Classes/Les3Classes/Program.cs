using System;

namespace Les3Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Rekenmachine rekenmachine = new Rekenmachine();

            Console.WriteLine(rekenmachine.Optellen(3, 3));
            Console.WriteLine(rekenmachine.Delen(2, 4));
            Console.WriteLine(rekenmachine.Vermenigvuldigen(3, 3));
        }
    }
}
