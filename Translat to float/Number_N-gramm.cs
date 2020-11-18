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

        public static int ConvertToTen(string x,int dim1,int dim2, char[] alphavit) 
        {
            Console.WriteLine($"1)Переводим в 10-ю сичтему счасления,прежде чем перевести в {dim2}:");
            Console.Write($"{x}({dim1})=");
            int xTen = 0;

            for (int i = 0; i < x.Length; i++)                                   
            {
                int k = x.Length - i-1;
                int  j = ReturnNumAlph(x[i],alphavit);
                Console.Write($"{j}*{dim1}^{k}");
                if (i!= x.Length - 1)
                {
                    Console.Write("+");
                }

                xTen += j * sqrt(dim1,k);
                //Console.Write($"({xTen})");
            }
            Console.WriteLine($"={xTen}");
            return xTen;
        }

        public static string ConvertToY(int xTen, int dim2, char[] alphavit)
        {
            Console.WriteLine($"2)Делим число {xTen} и его ответы с остатком до тех пор,пока от ответа не останется число меньшее {dim2}:");
            int z =xTen;
            int t = z;
            int ost = 0;
            string otvet = "";

            while (z != 0)
            {
                ost = t % dim2;
                t /= dim2;
                otvet +=alphavit[ost];

                Console.WriteLine($"{z}/{dim2}={t}({ost}={alphavit[ost]})");
                z = t;
            }
            return otvet = Flip(otvet);
        }

        public static string Flip(string otvet)
        {
            string retortStr= "";
            for (int i = 0; i < otvet.Length; i++)
            {
                retortStr += otvet[otvet.Length - i -1];
            }
            return retortStr;
        }
        //Напечатать таблице 50-ти чисел
    }
}
