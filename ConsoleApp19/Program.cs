﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
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
            int x, a, y, value;
            for (x = 4; x <= 7; x++)
            {
                for (a = 1; a <= 10; a++)
                {
                    y = x * 10;
                    value = y + a;
                    Console.Write($"{value} ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
    

