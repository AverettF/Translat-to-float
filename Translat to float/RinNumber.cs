using System;
using System.Collections.Generic;
using System.Text;

namespace Translat_to_float
{
    class RinNumber
    {
//<<<<<<< HEAD
          
//=======
        private enum NumberRim
        {
            I = 1, V = 5, X = 10, L = 50, C = 100, D = 500, M = 1000
        }

        public static void ConvertNumberRim(string number)
        {
            for (int i = 0; i < number.Length; i++)
            {
                int numberI = Convert.ToInt32(Convert.ToString(number[i]));
                int zero = 1;

                for (int j = i; j < number.Length - 1; j++)
                {
                    zero *= 10;
                }

                int xNull = numberI * zero;

                if ((numberI % 10 <= 3) && (numberI % 10 != 0))
                {
                    for (int k = 0; k < numberI % 5; k++)
                    {
                        Console.Write((NumberRim)zero);
                    }
                }
                else if (numberI % 10 == 4)
                {
                    Console.Write((NumberRim)zero);
                    Console.Write((NumberRim)(5 * zero));
                }
                else if (numberI % 10 == 5)
                {
                    Console.Write((NumberRim)(5 * zero));
                }
                else if (((numberI % 10 >= 6) && (numberI % 10 <= 8)))
                {
                    Console.Write((NumberRim)(5 * zero));
                    for (int k = 0; k < numberI % 5; k++)
                    {
                        Console.Write((NumberRim)zero);
                    }
                }
                else if (numberI % 10 == 9)
                {
                    Console.Write((NumberRim)zero);
                    Console.Write((NumberRim)(zero * 10));
                }
                else if (numberI % 10 == 0)
                {
                    Console.Write((NumberRim)zero);
                }
                //hel
            }
        }
//>>>>>>> b1
    }
}
