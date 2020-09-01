using System;

namespace Ogunwale_PE6
{
    class Program
    {
        static void Main(string[] args)
            //Main program
        {
            //this is the hidden number
            //it generates a new Random number between 0 and 100
            int secret = new Random().Next(0, 100);

            //since you guess first, then you can get into the for loop which starts with the first guess
            Console.WriteLine("Guess the surprise number between 0 and 100!");
            for (int i = 1; i < 9; i++)
            {
                //Console.WriteLine("Guess the surprise number between 0 and 100!");
                //Kenki shall be the user's guess
                var kenki = Convert.ToInt32(Console.ReadLine());

                //This if statement is for when the user gets the number right
                if (kenki == secret)
                {
                    Console.WriteLine("Congratulations! It took you a total of " + i + " tries to guess correctly!");

                }

                //This else if statement will prompt the user if their input is less than 0
                if (kenki < 0)
                {
                    Console.WriteLine("Invalid Number, try again.: ");

                }

                //Gives a game over if the guess game is over 8 guesses and breaks the loop
                else if (i >= 8)
                {
                    Console.WriteLine("Game Over! The number was: " + secret);
                    break;

                }


                //This else if statement will prompt the user if their input is less than the number.
                else if (kenki < secret)
                {
                    Console.WriteLine("Too low, try again! Enter your guess!: ");

                }


                //This else if statement will prompt the user if their number is greater than 100
                if (kenki > 100)
                {
                    Console.WriteLine("Invalid number, try again.: ");

                }

                //This else if statement will prompt the user if their input is greater than the number.
                else if (kenki > secret)
                {
                    Console.WriteLine("Too high, try again! Enter your guess!: ");

                }


             

            }
            

        }

    }
}
