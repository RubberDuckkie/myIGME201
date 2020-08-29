using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oguunwale_PE4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give me your first number: ");
            string var1 = Console.ReadLine();
            int num1 = Convert.ToInt32(var1);

            Console.WriteLine("Give me the second number: ");
            string var2 = Console.ReadLine();
            int num2 = Convert.ToInt32(var2);

            bool red = false;
            while(red != true) { 
                if (!(num1 <= 10 == true) != !(num2 <= 10 == true))
                {
                    Console.WriteLine("One of the numbers " + num1 + " or " + num2 + " are less then or equal to 10.");
                    red = true;
                }
                else if ((num1 > 10 || num2 > 10) && (num1 > 10 == true) == (num2 > 10 == true)) {
                    Console.WriteLine("Both " + num1 + " and " + num2 + " are greater than 10");

                    Console.WriteLine("Give me your first number: ");
                    var1 = Console.ReadLine();

                    Console.WriteLine("Give me the second number: ");
                    var2 = Console.ReadLine();
                    num1 = Convert.ToInt32(var1);
                    num2 = Convert.ToInt32(var2);
                } else {
                    Console.WriteLine("Both " + num1 + " and " + num2 + " are less than 10");

                    Console.WriteLine("Give me your first number: ");
                    var1 = Console.ReadLine();

                    Console.WriteLine("Give me the second number: ");
                    var2 = Console.ReadLine();
                    num1 = Convert.ToInt32(var1);
                    num2 = Convert.ToInt32(var2);

                }

            }
        /*int number = 3;
        switch (number)
        {
            case 1:
                Console.WriteLine("Just");
                break;
            case 2:
                break;
            case 4:
                Console.WriteLine("an");
                break;

            default:
                Console.WriteLine("example");
                break;
        }*/



    }
    }
}
