using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_statement_exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter a four digit pin number");
            int pin1 = int.Parse(Console.ReadLine());

            if (pin1 > 9999 && pin1 < 1000)
            {

                Console.WriteLine("please re-enter the pin");
                int pin2 = int.Parse(Console.ReadLine());

                if (pin1 == pin2)
                    Console.WriteLine("pin accepted");

                else
                    Console.WriteLine("pin was not set");

                Console.WriteLine("***************");
                Console.ReadLine();

            }



        }
    }
}
