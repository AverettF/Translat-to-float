using System;
using System.Collections.Generic;
using System.Text;

namespace Translat_to_float
{
    class CheckFool
    {
        public static bool CheckNumNDim(string x, int forD, char[] alphavit)
        {
            for (int i = 0; i < x.Length; i++)
            {

                if (x[i] < alphavit[forD])
                    continue;
                else
                    return false;                
            }
            return true;
        }

        public static int ReadDimantion()
        {
            bool isSuccess =false;
            int dim = 0;

            while (!isSuccess)
            {
                do
                {
                    isSuccess = int.TryParse(Console.ReadLine(), out dim);

                    if (!isSuccess)
                        Console.WriteLine("Неверный ввод");

                } while (!isSuccess);

                //if (!(dim>2 && dim < 50))
                //{
                //    isSuccess = false;
                //    Console.WriteLine("Неверный ввод2");
                //}

            }
            return dim;
        }
    }
}
