using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBoilerPlate
{
    class Program
    {
        static void Main(string[] args)
        {
            /*separate ints into packets*/
            long val =    876543210;
                          3130002302
            long exp = 100000000;
            while (val > 0)
            {
                Console.WriteLine((val - (val % exp))/exp + ":");
                val -= (val - (val % exp));
             //   val /= 10;
                exp /= 10;
            }
            Console.Read(); Console.Read(); Console.Read(); Console.Read();
            int one = 1000;
            int two =  1000;

            Console.WriteLine(one);
            Console.WriteLine(two);
            Console.Read();

            Console.WriteLine(one + (two * 1000));
            Console.Read();

            Console.Read();
            Console.Read();

            /*turn array of ints into a long*/
            int[] inputs = { 5, 0, 2, 3, 0, 5, 6, 7, 8, 9 };
            
            long new_val = 0;
            for (int j = 0; j < 10; j++)
            {
                new_val += inputs[j] * (long)Math.Pow(10, (9-j));
                Console.WriteLine(new_val);
            }
          
            Console.Read();
            Console.Read();
            Console.Read();

            /*separate ints into packets*/
            

            Console.WriteLine(one);
            Console.WriteLine(two);
            Console.Read();

            Console.WriteLine(one + (two * 1000));
            Console.Read();

            Console.Read();
            Console.Read();
        }
    }
}
