using System;
using System.Threading;

namespace Risovanie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            int pos = Console.CursorTop;
            Console.SetCursorPosition(50, 20);
            Console.SetCursorPosition(10, pos);

            var rand = new Random();

            for (int i = 0; i <= 100; i++)
            {
                string pct = string.Format( new string((char)0x2592, i * 30 / 100), i);
                Console.CursorLeft = 0;
                Console.Write(pct);
                Thread.Sleep(rand.Next(0, 50));
            }
            Console.WriteLine();
            Console.ResetColor();
        }

        static void Print(string message, int delay)
        {
            Thread.Sleep(delay);
            Console.WriteLine(message);
        }
    }
}