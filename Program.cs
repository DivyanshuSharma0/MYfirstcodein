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
            int i;
            for (i = 1; i < 100;i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine("The no. divisible by 3 are " + i);
                }
            }
        }
    }
}
