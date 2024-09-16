using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24._09._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            int y = 0;
            int i = 1;
            string style = "█";
            Console.ForegroundColor = ConsoleColor.Yellow;
            while (i > 0) 
            {
                Console.SetCursorPosition(x, y);
                //╚╝╔╗║═
                /*Console.Write("╔");
                for (int j = 1; j < Console.WindowWidth - 1; j++)
                {
                    Console.Write('═');
                }
                Console.Write('╗');
                for (int j = 1; j < Console.WindowHeight - 1; j++)
                {
                    Console.SetCursorPosition(Console.WindowWidth - 1, j);
                    Console.Write("║");
                }
                Console.SetCursorPosition(Console.WindowWidth - 1, Console.WindowHeight - 1);
                Console.Write('╝');
                for (int j = Console.CursorLeft -1; j > 0; j--)
                {
                    Console.SetCursorPosition(j, Console.WindowHeight - 1);
                    Console.Write('═');
                }
                Console.SetCursorPosition(0, Console.WindowHeight - 1);
                Console.Write('╚');
                for (int j = Console.WindowHeight - 2; j > 0; j--)
                {
                    Console.SetCursorPosition(0, j);
                    Console.Write("║");
                }*/

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(style);
                switch (Console.ReadKey().Key) 
                {
                    case ConsoleKey.LeftArrow:
                        if (x > 0)
                        {
                            x--;
                            Console.SetCursorPosition(x, y);
                            break;
                        }
                        else
                        {
                            break;
                        }
                    case ConsoleKey.RightArrow: 
                        x++;
                        Console.SetCursorPosition(x, y);
                        break;
                    case ConsoleKey.UpArrow:
                        y--;
                        Console.SetCursorPosition(x, y);
                        break;
                    case ConsoleKey.DownArrow:
                        y++;
                        Console.SetCursorPosition(x, y);
                        break;
                    case ConsoleKey.NumPad1:
                        Console.ForegroundColor = ConsoleColor.Red; 
                        break;
                    case ConsoleKey.NumPad2:
                        Console.ForegroundColor= ConsoleColor.Green; 
                        break;
                    case ConsoleKey.NumPad3:
                        Console.ForegroundColor= ConsoleColor.White;
                        break;
                    case ConsoleKey.Spacebar:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.ResetColor();
                        break;
                    case ConsoleKey.D1:
                        style = "█";
                        break;
                    case ConsoleKey.D2:
                        //█▓▒░
                        style = "▓";
                        break;
                    case ConsoleKey.D3:
                        style = "▒";
                        break;
                    case ConsoleKey.D4:
                        style = "░";
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
