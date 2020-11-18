using System;
using System.Collections.Generic;
using System.Text;

namespace Translat_to_float
{
    class Menu
    {
        public static void PrintMain(int MenuSelect)
        {
            if (MenuSelect == 0)
                Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tПеревод целых чисел из одной системы счисления в другую(max 50)\n");
            Console.ResetColor();

            if (MenuSelect == 1)
                Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tПеревод чиселв римские цифры\n");
            Console.ResetColor();

            //if (MenuSelect == 2)
            //    Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("\t\n");
            //Console.ResetColor();

            //if (MenuSelect == 3)
            //    Console.ForegroundColor = ConsoleColor.Green;
            //Console.WriteLine("\tExit\n");
            //Console.ResetColor();
        }

        public static int GetSelectMenu(ConsoleKeyInfo key, int i, int menuLong)
        {
            if ((key.Key == ConsoleKey.W || key.Key == ConsoleKey.UpArrow) && (i != 0))
                return i - 1;
            else if ((key.Key == ConsoleKey.S || key.Key == ConsoleKey.DownArrow) && (i != menuLong))
                return i + 1;
            else
                return i;
        }

        public static void PrintRim(int MenuSelect)
        {
            if (MenuSelect == 0)
                Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\tВ римские цифры\n");
            Console.ResetColor();

            if (MenuSelect == 1)
                Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("\tИз римских цифр\n");
            Console.ResetColor();
        }
    }
}
