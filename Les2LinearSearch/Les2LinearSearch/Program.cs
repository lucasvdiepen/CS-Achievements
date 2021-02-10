using System;

namespace Les2LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[]
            {
                "Joe",
                "Rick",
                "Sam",
                "Giovanni",
                "Ramses",
                "Laura",
                "Laurens",
                "Lydia",
                "Eric",
                "Rose"
            };

            string nameToFind = "Joe";

            int index = FindInArray(names, nameToFind);

            if(index == -1)
            {
                Console.WriteLine("Did not find: " + nameToFind);
            }
            else
            {
                Console.WriteLine("Found at: " + index);
            }
        }

        private static int FindInArray(string[] list, string nameToFind)
        {
            for(int i = 0; i < list.Length; i++)
            {
                if (list[i] == nameToFind) return i;
            }

            return -1;
        }
    }
}
