using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
                long sum = 0;
                long num1 = 0;
                long num2 = 1;

            for (int i = 1; i < 100; i++)
            {
                long endNum = num1 + num2;
                Console.WriteLine(endNum);

                num1 = num2;
                num2 = endNum;

                if (endNum < 4000000 && endNum % 2 == 0)
                {
                    sum += endNum;
                }
                else if (endNum > 4000000)
                {
                    Console.WriteLine("The sum is "+sum);
                    Console.ReadKey();
                }
            }
        }
    }
}
