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
            int i, c = 0;
            for (i = 1; i < 100; i++)
            {
                if (i % 3 == 0)
                {
                    c++;
                }
            }
            Console.WriteLine("the count of no which is divisible by 3 till 100 is "+ c);
            Console.ReadLine();
        }
    }
}
