using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrayq2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numberArray = new int[] { 34, 5, 67, 1, 99, 34, 44, 78, 34, 0 };
            int sum = 0;

            for (int i = 0; i < 10; i++)
            {
                sum = sum + numberArray[i];
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}
