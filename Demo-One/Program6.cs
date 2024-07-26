using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_One
{
    internal class Program6
    {
        // Loops
        // do-while, while , for , foreach
        // every loop woll have some statements
        //  1. starting point
        // 2. Condition
        //3 . inc / dec
        static void Main()
        {
            // print 1 to 10
            Console.WriteLine("using do while loop");
            int x = 1;
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x <= 10);

            Console.WriteLine("using while loop");
            x = 1;
            while (x <= 10)
            {
                Console.WriteLine(x);
                x++;
            }

            Console.WriteLine("using for loop");
            for(int i=1;i<=10;i++)
            {

            Console.WriteLine(i); 
            }
        }
    }
}
