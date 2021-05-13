using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, num, fact = 1;
            Console.WriteLine("The no. which you want to factorize");
            num = int.Parse(Console.ReadLine());
            for (i = 1; i < num + 1; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("The factorial of " + num + " is " + fact);
            Console.ReadLine();
        }
    }
}

