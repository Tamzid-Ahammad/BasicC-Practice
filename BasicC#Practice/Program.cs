using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicC_Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please give an integer value for x");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Please give an integer value for y");
            int y = Convert.ToInt32(Console.ReadLine());
            if(x % 2 == 0)
            {
                Console.WriteLine("It is an even number");
            }
            else
            {
                Console.WriteLine("It is an odd number");
            };

            if( x % y == 0.0000)
            {
                Console.WriteLine("It is an even number");
            }

            else
            {
                Console.WriteLine("It is an odd number");
            };

            //  IF-else-if ladder Statement

            Console.WriteLine("Please give an integer value for num");
            int num = Convert.ToInt32(Console.ReadLine());
            if(num >= 1 && num <= 32)
            {
                Console.WriteLine("This student do not get passing mark");

            }
            else if(num >= 33 && num <= 39)
            {
                Console.WriteLine("This student passing grade is D");
            }
            else if (num >= 40 && num <= 49)
            {
                Console.WriteLine("This student passing grade is C");
            }
            else if (num >= 50 && num <= 59)
            {
                Console.WriteLine("This student passing grade is B");
            }
            else if (num >= 60 && num <= 69)
            {
                Console.WriteLine("This student passing grade is A-");
            }

            else if (num >= 70 && num <= 79)
            {
                Console.WriteLine("This student passing grade is A");
            }

            else if (num >= 80 && num <= 100)
            {
                Console.WriteLine("This student passing grade is A+");
            }

            else
            {
                Console.WriteLine("This student did not attend the exam");
            }

           


            Console.ReadLine();


        }
    }
}
