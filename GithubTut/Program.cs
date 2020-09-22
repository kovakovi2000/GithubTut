using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GithubTut
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("This is a test code for Github upload.");
            Console.WriteLine("Kovács Bence");
            for (int i = 0; i < 100; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(
                    rnd.Next(Console.WindowWidth),
                    rnd.Next(Console.WindowHeight));
                Console.Write("*");
            }
            Console.ReadKey();
        }
    }
}