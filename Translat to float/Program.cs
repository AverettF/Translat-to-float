using System;

namespace Translat_to_float
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphavit = new char[50];
            alphavit =Number_N_gramm.GetAlphavit();

            ConsoleKeyInfo key;
            int i = 0;
            do
            {
                Menu.PrintMain(i);

                key = Console.ReadKey();
                i = Menu.GetSelectMenu(key, i,2);
                Console.Clear();

                if (key.Key == ConsoleKey.Enter)
                    SelectMenu(i,alphavit);

            } while (!(key.Key == ConsoleKey.Enter && i == 3));
            
        }

        static void SelectMenu(int i , char[] alphavit)
        {
            switch (i)
            {
                case (0):
                    ConvertToNDim(alphavit);

                    break;
                case (1):
                    ConvertToRim();
                    break;
                case (2):
                    Console.WriteLine("Здесь будет перевод в тип float");
                    break;
                case (3):
                    Console.WriteLine("пока-пока");
                    break;
            }
        }

        static void ConvertToNDim(char[] alphavit)
        {
            ConsoleKeyInfo key ;
            bool checkBool = false;
            string number = "";
            int dim1, dim2 = 0;
            do
            {
                Console.WriteLine("Введите первое число");
                number = Console.ReadLine();                        //TODO:Сделать проверку числа
                Console.WriteLine("Введите размерность первого числа");
                dim1 = CheckFool.ReadDimantion();
                Console.WriteLine("Введите в какую размерность вы хотите перевести даное число");
                dim2 = CheckFool.ReadDimantion();

                checkBool = CheckFool.CheckNumNDim(number, dim1, alphavit);

                if (!checkBool)
                {
                    Console.WriteLine("Неверно введено число,повотриет попытку");
                }
            } while (checkBool != true);

            int xTen = Number_N_gramm.ConvertToTen(number, dim1, dim2, alphavit);
            string otvet =Number_N_gramm.ConvertToY(xTen, dim2, alphavit);

            Console.WriteLine($"\nОтвет:{number}({dim1})={otvet}({dim2})");

            Console.WriteLine("\nЧтобы выйти нажмите Esc");
            do
            {
                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.Escape);
            Console.Clear();
        }

        static void ConvertToRim()
        {
            ConsoleKeyInfo key;
            int i = 0;
            do
            {
                Console.WriteLine("Что именно?");
                Menu.PrintRim(i);

                key = Console.ReadKey();
                i = Menu.GetSelectMenu(key, i,2);
                Console.Clear();

                if (key.Key == ConsoleKey.Enter)
                    break;                   
            } while (key.Key != ConsoleKey.Enter);

            Console.WriteLine("Введите число");

            if (i==0)
            {
                string x = Console.ReadLine();
                RinNumber.ConvertNumberRim(x);
            }
            else
            {
                Console.WriteLine("Извинетие,то тут ведутся работы");
            }
            Console.WriteLine("Чтобы выйти нажмите Esc");

            do
            {
                key = Console.ReadKey();
            } while (key.Key != ConsoleKey.Escape);
            Console.Clear();
        }
    }
}
