﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_One
{
    internal class Program4
    {
        static void Main()
        {
            int num1, num2;
            int ch;
            Console.WriteLine("enter num1");
            num1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("enter num2");
            num2 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("enter choice");
            ch = Convert.ToByte(Console.ReadLine());
            if (ch == 1)
                Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
            else if (ch == 2)
                Console.WriteLine($"Difference of {num1} and {num2} is {num1 - num2}");
            else if (ch == 3)
                Console.WriteLine($"Product of {num1} and {num2} is {num1 * num2}");
            else if (ch == 4)
                Console.WriteLine($"Remainder of {num1} and {num2} is {num1 % num2}");
            else
                Console.WriteLine("invalid choice");
        }
    }
}
