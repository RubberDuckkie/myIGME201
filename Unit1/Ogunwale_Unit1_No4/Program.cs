using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ogunwale_Unit1_No4
{
    class Program
    {

        static void Main(string[] args)
        {
            //the name of the number of what the user's choice is
            int uChoice;
            //global variables for the answers
            string userAns1;
            string ans1 = "black";
            int userAns2;
            int ans2 = 42;
            string userAns3;
            string ans3 = "What Do you mean? African or European swallow?";
            string decision;
            string agree = "yes";
            string deny = "no";

            //main question set
            Console.WriteLine("Choose your question (1 - 3):");
            uChoice = Convert.ToInt32(Console.ReadLine());

         
            //first options
            if (uChoice == 1){
                Console.WriteLine("You have 5 Seconds to Answer the following question:");
                Console.WriteLine("What is your favorite color?: ");
                userAns1 = Console.ReadLine();
                if (userAns1 == ans1)
                {
                    Console.WriteLine("Well Done!");
                    Console.WriteLine("Would you like to play again?");
                    decision = Console.ReadLine();
                    if (decision == agree)
                    {
                        return;
                    }
                    else if (decision == deny)
                    {
                        return;

                    }
                }
                else
                {
                    Console.WriteLine("Wrong! The Answer is: " + ans1);

                }

            }
            //second choices
            else if (uChoice == 2)
            {
                Console.WriteLine("You have 5 Seconds to Answer the following question:");
                Console.WriteLine("What is the answer to life, the universe and everything?");
                userAns2 = Convert.ToInt32(Console.ReadLine());
                if (userAns2 == ans2)
                {
                    Console.WriteLine("Well Done!");
                    Console.WriteLine("Would you like to play again?");
                    decision = Console.ReadLine();
                    if (decision == agree)
                    {
                        return;
                    }
                    else if (decision == deny) 
                    {
                        return;

                    }


                }
                else
                {
                    Console.WriteLine("Wrong! The Answer is: " + ans2);

                }

            }
            //third choices
            else if (uChoice == 3)
            {
                    Console.WriteLine("You have 5 Seconds to Answer the following question:");
                Console.WriteLine("What is the airspeed velocity of an unladen swallow?");
                userAns3 = Console.ReadLine();
                if (userAns3 == ans3)
                {
                    Console.WriteLine("Well Done!");
                    Console.WriteLine("Would you like to play again?");
                    decision = Console.ReadLine();
                    if (decision == agree)
                    {
                        return;
                    }
                    else if (decision == deny)
                    {
                        return;

                    }
                }
                else
                {
                    Console.WriteLine("Wrong! The Answer is: " + ans3);
                }

            }
            else {
                Console.WriteLine("Invalid parameters,");
            
            }
                

        
        }
    }
}
