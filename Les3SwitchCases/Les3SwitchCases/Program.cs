using System;

namespace Les3SwitchCases
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Write("Input: ");
                string input = Console.ReadLine();

                if(int.TryParse(input, out int result))
                {
                    switch(result)
                    {
                        case 0:
                            Console.WriteLine("Hey, je hebt een 0 ingevoerd");
                            break;
                        case 1:
                            Console.WriteLine("Hey, je hebt een 1 ingevoerd");
                            break;
                        default:
                            Console.WriteLine("Hey, dit is de default case. De waarde die je hebt ingevoerd was: " + result);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("De input moet een getal zijn");
                }

                Console.WriteLine("");
            }
        }
    }
}
