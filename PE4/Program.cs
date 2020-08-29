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
            //Takes the first number and converts it into an integer
            Console.WriteLine("Give me your first number: ");
            string var1 = Console.ReadLine();
            int num1 = Convert.ToInt32(var1);
            //Takes the second number and converts it into an integer
            Console.WriteLine("Give me the second number: ");
            string var2 = Console.ReadLine();
            int num2 = Convert.ToInt32(var2);
            
            //boolean for the while loop
            bool red = false;
            while(red != true) { 
                //an if statement that sets up for the ^ truth table
                if (!(num1 <= 10 == true) != !(num2 <= 10 == true))
                {
                    Console.WriteLine("One of the numbers " + num1 + " or " + num2 + " are less then or equal to 10.");
                    red = true;
                }
                //checks if both num1 and num2 are greater than 10
                else if ((num1 > 10 || num2 > 10) && (num1 > 10 == true) == (num2 > 10 == true)) {
                    Console.WriteLine("Both " + num1 + " and " + num2 + " are greater than 10");

                    Console.WriteLine("Give me your first number: ");
                    var1 = Console.ReadLine();

                    Console.WriteLine("Give me the second number: ");
                    var2 = Console.ReadLine();
                    num1 = Convert.ToInt32(var1);
                    num2 = Convert.ToInt32(var2);
                } else {
                    //else statement that both num1 and num2 are less than 10
                    Console.WriteLine("Both " + num1 + " and " + num2 + " are less than 10");
                    
                    //resets if the num1 and num2 are the same
                    Console.WriteLine("Give me your first number: ");
                    var1 = Console.ReadLine();

                    Console.WriteLine("Give me the second number: ");
                    var2 = Console.ReadLine();
                    num1 = Convert.ToInt32(var1);
                    num2 = Convert.ToInt32(var2);

                }

            }
            //Question 4
       int number = 3;
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
        }



    }
    }
}
