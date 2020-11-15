using System;
using System.Collections.Generic;
using System.Text;

namespace Translat_to_float
{
    class Number_N_gramm
    {
        public static char[] GetAlphavit()
        {
            char[] massChar = new char[50];

            for (int i = 0; i < 10; i++)
            {
                massChar[i] = Convert.ToChar(Convert.ToString(i));
            }

            for (int i = 65; i <= 90; i++)
            {
                massChar[10+i-65] = Convert.ToChar(i);
            }
            massChar[36] = '<';
            massChar[37] = '*';
            massChar[38] = '&';
            massChar[39] = '%';
            massChar[40] = '$';
            massChar[41] = '#';
            massChar[42] = '@';
            massChar[43] = '!';
            massChar[44] = '?';
            massChar[45] = '+';
            massChar[46] = '-';
            massChar[47] = '№';
            massChar[48] = '~';
            massChar[49] = '^';

            return massChar;
        }

        private static int ReturnNumAlph(char x, char[] alphavit)
        {
            for (int i = 0; i < 50; i++)
            {
                if (x == alphavit[i])
                {
                    return i;
                }
            }
            return 0;
        }

        private static int sqrt(int x, int y)
        {
            int z = 1;
            for (int i = 1; i <= y; i++)
            {
                z *= x;
            }
            return z;
        }

        public static void ConvertToY(string x,int razmernost,int Vrazmernost, char[] alphavit) 
        {
            Console.WriteLine($"1.Переводим в 10-ю сичтему счасления,прежде чем перевести в {Vrazmernost}:");
            Console.Write($"{x}({razmernost})=");
            int xTen = 0;

            for (int i = 0; i < x.Length; i++)                                   
            {
                int k = x.Length - i-1;
                int  j = ReturnNumAlph(x[i],alphavit);
                Console.Write($"{j}*{razmernost}^{k}");
                if (i!= x.Length - 1)
                {
                    Console.Write("+");
                }

                xTen += j * sqrt(razmernost,k);
                //Console.Write($"({xTen})");
            }
            Console.WriteLine($"={xTen}");

        }



        //Напечатать таблице 50-ти чисел
    }
}
