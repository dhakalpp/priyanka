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
            Console.WriteLine("please enter a number i will tell you if it's odd or even");
            int input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
                Console.WriteLine("the num you gave me was even");
            else
                Console.WriteLine(" the num you gave me was odd");

            Console.WriteLine("*************");
            Console.ReadLine();
        }  
    }
}
