using System;

namespace Les5GettersEnSetters
{
    class Program
    {
        class Dog
        {
            private string name = "";
            private int age = -1;
            private Paw paw;

            public Dog(string _name, int _age)
            {
                paw = new Paw();
                name = _name;
                age = _age;
            }

            public Paw GetPaw()
            {
                return paw;
            }

            public Paw GetNewPaw()
            {
                return new Paw();
            }

            public string GetName()
            {
                return name;
            }

            public int GetAge()
            {
                return age;
            }
        }

        class Paw
        {
            private bool isClean = false;

            public void Clean()
            {
                isClean = true;
                Console.WriteLine("Paw cleaned");
            }

            public bool IsClean()
            {
                return isClean;
            }
        }

        static void Main(string[] args)
        {
            Dog dog = new Dog("DogName", 2);

            Paw paw = dog.GetPaw();
            Console.WriteLine(paw.IsClean());

            Paw newPaw = dog.GetNewPaw();
            newPaw.Clean();
            Console.WriteLine(newPaw.IsClean());
        }
    }
}
