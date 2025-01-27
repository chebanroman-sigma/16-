using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp23
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
             int x, y;
               for (x = 1; x <= 4; x++)
               {
                   for (y = 1; y <= 7; y++)
                   {
                     Console.Write("#");
                   }
                 Console.WriteLine($"  ");
                 Console.WriteLine($"  ");
               }
           }
    }    
}
