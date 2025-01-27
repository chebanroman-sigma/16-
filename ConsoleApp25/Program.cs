using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
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
            int x = 8;
            for (int y = 0; y <= x; y++)
            {
                Console.Write(new string(' ', y));
                Console.WriteLine("#");
            }
        }
    }
}
