using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayQ3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numberList = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("input a number");
                numberList.Add(int.Parse(Console.ReadLine()));
            }
            Console.WriteLine("Five Input numbers are");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("" + numberList[i]);
            }
            int counter = 0;
            while (true)

            {
                Console.WriteLine("input another number");
                int anotherNumber = int.Parse(Console.ReadLine());


                if (numberList.Contains(anotherNumber))
                {
                    Console.WriteLine("The number exists");
                    ++counter;
                    Console.WriteLine("Times number repeated "+ counter);

                }
                else
                {
                    Console.WriteLine("this is a  new number");
                    continue;
                }


                Console.ReadLine();
            }
        }
    }
}
