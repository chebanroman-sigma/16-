using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Func();
                Console.Read();
            }
        }
        static void Func()
        {
            for (int x = 1; x <= 4; x++)
            {
                for (int a = 1; a <= 10; a++)
                {
                    Console.Write($"{a} ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
