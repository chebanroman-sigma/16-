using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp24
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
            int size = 16;
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {

                    if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                    {
                        Console.Write("#");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }

                Console.WriteLine();
}   }   }   }






