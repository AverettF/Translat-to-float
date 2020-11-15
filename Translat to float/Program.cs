using System;

namespace Translat_to_float
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            char[] alphavit = new char[50];
            alphavit =Number_N_gramm.GetAlphavit();

            for (int i = 0; i < 50; i++)
            {
                Console.Write($"{i}:{alphavit[i]} ");
            }
            Number_N_gramm.ConvertToY("ABC",16,10,alphavit);
        }
    }
}
