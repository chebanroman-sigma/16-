using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
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

            public static void Func()
            {
                for (int x = 1; x <= 5; x++)
                {
                    for (int y = 5; y >= x; y--)
                    {
                        Console.Write("1 ");

                    }
                    Console.WriteLine(" ");
                }
            }
        
}    }

    

