using System;

namespace Les2VariablesAndDatatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int intWaarde = 1;
            float floatWaarde = (float)intWaarde;
            bool boolWaarde = Convert.ToBoolean(floatWaarde);

            Console.WriteLine("Int waarde: " + intWaarde);
            Console.WriteLine("Float waarde: " + floatWaarde);
            Console.WriteLine("Bool waarde: " + boolWaarde);
        }
    }
}
