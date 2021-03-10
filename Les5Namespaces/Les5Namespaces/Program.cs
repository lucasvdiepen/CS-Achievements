using System;

using DogNamespace;
using PawNamespace;

namespace Les5Namespaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();

            Paw paw = dog.GetPaw();
            paw.Clean();

            Console.WriteLine(paw.IsClean());
        }
    }
}
