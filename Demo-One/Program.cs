﻿// in C #include<stdio.h> printf scanf
// in java , import package
using System;   // namespace

namespace Demo_One  // namespace > logical collection of related classes
{
    internal class Program  // there shud be min 1 class that 
        // shud contain Main method
    {
        static void Main(string[] args) // entry & exit point for program
        {
            Console.Write("Hello, World!\n");
            Console.Write("Hello, World!\n");
            Console.Write("Hello, World!\n");
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            Console.WriteLine("Hello");
            // var declaration & initialzation
            int x = 10;
            Console.WriteLine("value of x is " + x);
            // {0} is placeholder
            // printf("%d",x);
            Console.WriteLine("Value of x is {0}", x);
            // string interpolation
            Console.WriteLine($"Value of x is {x}");
            int num1 = 10, num2 = 20;
            Console.WriteLine("Sum of num1 & num2 is " + (num1+ num2));
            Console.WriteLine("Sum of " + num1 + " and " + num2 + " is " + (num1+num2));
            Console.WriteLine("Sum of {0} and {1} is {2}", num1, num2, (num1 + num2));
            Console.WriteLine($"Sum of {num1} and {num2} is {num1+num2}"); 
            // in C printf("hello");

            // Console is class which belongs to System namspace
            // WriteLine() is method that belongs to Console class
        }
    }
}
