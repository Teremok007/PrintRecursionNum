using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNumber(12345);
            Console.ReadKey();
        }

        public static void PrintNumber(int num)
        {
            if (num > 9)
            {
                PrintNumber((int)(num/10));
            }
            Console.Write(num % 10);
        }
    }
}

/*
 * Используя команды Console.Write() лишь при x = 0..9, 
 * написать рекурсивную программу печати десятичной 
 * записи целого положительного числа n.
*/