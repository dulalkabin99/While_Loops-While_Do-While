using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            while (counter <= 9)
            {
                Console.WriteLine("Number: " + counter);
                counter++;
            }
            
            // Sum of the Number 1 to N
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~While Loop~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.Write("Please Enter a Number to get a sum from 1 To N = ");
            int n = int.Parse(Console.ReadLine());
            int num = 1;
            int sum = 1;
            Console.Write("The sum  of "+ sum);
            while (num < n)
            {
                num++;
                sum += num;
                Console.Write(" + " + num);
            }
            Console.WriteLine(" = " + sum);
            
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~While Loop With Break~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("Enter a Number for factorial");
            num = int.Parse(Console.ReadLine());
           
            decimal factorial = 1;
            // Perform an "infinite loop"
            while (true)
            {
                if (num <= 1)

                {
                    break;
                }
                factorial *= num;
                num--;
            }
            Console.WriteLine("The ! of this Number is  = " + factorial);




            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ Do_ While Loop~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");

            Console.WriteLine("number to Factorize = ");
            num = int.Parse(Console.ReadLine());
            factorial = 1;
            do
            {
                factorial *= num;
                num--;
            } while (num > 0);
            Console.WriteLine("The ! of this Number is = " + factorial);

            Console.ReadLine();
            
        }
    }
}
