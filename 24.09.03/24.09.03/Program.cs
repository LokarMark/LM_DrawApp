using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _24._09._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = Console.WindowWidth / 2;
            int y = Console.WindowHeight / 2 + 2;
            int j = 0;
            string style = "";
            //█ ▓ ▒ ░

            string[] color = new string[] {"Piros", "Zöld", "Kék", "Fehér", "Cián", "Sötét kék", "Sötét cián", "Sötét zöld", "Magenta"};

            Console.Write("Adjon meg egy színt (Piros, Zöld, Kék, Fehér, Cián, Sötét kék, Sötét cián, Sötét zöld, Magenta): " );
            string choice = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Válasszon egy láthatóságot (1 és 4 között tud válogatni, 1 = 100%, 4 = 25%): ");
            int opacity = Convert.ToInt32(Console.ReadLine());

            Console.Write("A választott Szín és láthatóság: ");


            switch (choice)
            {
                case "Piros":
                    Console.Write("Piros, ");
                    break;
                case "Zöld":
                    Console.Write("Zöld, ");
                    break;
                case "Kék":
                    Console.Write("Kék, ");
                    break;
                case "Fehér":
                    Console.Write("Fehér, ");
                    break;
                case "Cián":
                    Console.Write("Cián, ");
                    break;
                case "Sötét kék":
                    Console.Write("Sötét kék, ");
                    break;
                case "Sötét cián":
                    Console.Write("Sötét cián, ");
                    break;
                case "Sötét zöld":

                    Console.Write("Sötét zöld, ");
                    break;
                case "Magenta":

                    Console.Write("Magenta, ");
                    break;
            }

            switch (opacity)
            {
                case 1:
                    style = "█";
                    Console.Write("100%\n");
                    break;
                case 2:
                    style = "▓";
                    Console.Write("75%\n");
                    break;
                case 3:
                    style = "▒";
                    Console.Write("50%\n");
                    break;
                case 4:
                    style = "░";
                    Console.Write("25%\n");
                    break;
            }
            Console.WriteLine("A funkció billentyűkkel később tudja állítani mindkét értéket.");
            do
            {

                //╔╗╚╝║═
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write('╔');
                for (int i = 1; i < Console.WindowWidth - 1; i++)
                {
                    Console.Write('═');
                }
                Console.Write('╗');
                for (int i = 6; i < Console.WindowHeight - 1; i++)
                {
                    Console.SetCursorPosition(Console.WindowWidth - 1, i);
                    Console.Write("║");
                }
                Console.SetCursorPosition(Console.WindowWidth - 1, Console.WindowHeight - 1);
                Console.Write('╝');
                for (int i = Console.CursorLeft - 1; i > 0; i--)
                {
                    Console.SetCursorPosition(i, Console.WindowHeight - 1);
                    Console.Write('═');
                }
                Console.SetCursorPosition(0, Console.WindowHeight - 1);
                Console.Write('╚');
                for (int i = Console.WindowHeight - 2; i > 5; i--)
                {
                    Console.SetCursorPosition(0, i);
                    Console.Write("║");
                }
                j++;
            } while (j < 1);


            switch (choice)
            {
                case "Piros":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "Zöld":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "Kék":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "Fehér":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                case "Cián":
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case "Sötét kék":
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    break;
                case "Sötét cián":
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    break;
                case "Sötét zöld":
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    break;
                case "Magenta":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
            }

            while (true)
            {
                Console.SetCursorPosition(x, y);

                switch (Console.ReadKey(true).Key) 
                {
                    case ConsoleKey.LeftArrow:
                        if (x > 1) 
                        {
                            x--;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (x < Console.WindowWidth - 2)
                        {
                            x++;
                        }
                        break;
                    case ConsoleKey.UpArrow:
                        if (y > 1)
                        {
                            y--;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (y < Console.WindowHeight - 2)
                        {
                            y++;
                        }
                        break;
                    case ConsoleKey.F5:
                        Console.ForegroundColor = ConsoleColor.Red; 
                        break;
                    case ConsoleKey.F6:
                        Console.ForegroundColor = ConsoleColor.Green; 
                        break;
                    case ConsoleKey.F7:
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    case ConsoleKey.F8:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        break;
                    case ConsoleKey.F9:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        break;
                    case ConsoleKey.NumPad6:
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        break;
                    case ConsoleKey.F10:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        break;
                    case ConsoleKey.F11:
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        break;
                    case ConsoleKey.F12:
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        break;
                    case ConsoleKey.Spacebar:
                        Console.Write(style);
                        break;
                    case ConsoleKey.Backspace:
                        Console.Clear();
                        break;
                    //█ ▓ ▒ ░
                    case ConsoleKey.F1:
                        style = "█";
                        break;
                    case ConsoleKey.F2:
                        style = "▓";
                        break;
                    case ConsoleKey.F3:
                        style = "▒";
                        break;
                    case ConsoleKey.F4:
                        style = "░";
                        break;
                    case ConsoleKey.Escape:
                        return;
                    default:
                        break;
                }
            }
        }
    }
}
