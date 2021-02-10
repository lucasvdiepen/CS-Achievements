using System;

namespace Les2Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = {10, 20, 30, 40, 50, 60};

            int[] intArray2 = new int[intArray.Length];

            int array2Count = 0;
            for(int i = intArray.Length - 1; i >= 0; i--)
            {
                intArray2[array2Count] = intArray[i];
                array2Count++;
            }

            Console.WriteLine("Int array 1: " + string.Join(", ", intArray));
            Console.WriteLine("Int array 2: " + string.Join(", ", intArray2));
        }
    }
}
