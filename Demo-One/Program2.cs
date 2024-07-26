using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_One
{
    internal class Program2
    {
        static void Main()
        {
            // declare & initialze variable

            //int x = 10; 
            // take value from user
            int rn;
            string name;
            string course;
            int exp;

            Console.WriteLine("enter Rn");
            rn = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("enter name");
            name = Console.ReadLine();
            Console.WriteLine("enter course");
            course = Console.ReadLine();
            Console.WriteLine("enter exp");
            exp = Convert.ToByte(Console.ReadLine());

            Console.WriteLine($"Rn is {rn}\nName is {name}\n" +
                $"Course is {course}\nExp is {exp}");

        


            // scanf() cin>> Console.ReadLine();
            // Console.ReadLine() takes input in string form

            // int 2 bytes
            // short int 1 byte
            // long int 4 bytes


            //rn = Convert.ToI Console.ReadLine();

        }
    }
}
