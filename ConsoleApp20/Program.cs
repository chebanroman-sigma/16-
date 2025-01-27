using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Func();
                Console.Read();
        }
            static void Func()
            {
                int a = 5;
                for (int x = 1; x <= 5; x++)
                {
                    for (int y = 1; y <= x; y++)
                    {
                        Console.Write("5 ");
                    }
                    Console.WriteLine(" ");
                }
            }
    }
}
