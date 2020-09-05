using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogunwale_PE8_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Takes user input from the user
             Console.WriteLine("Give me a string, and ill reverse it!: ");
             string s = Console.ReadLine();
            //Tells the user thats reversing
            Console.WriteLine("Reverse, Reverse!");
            //Takes the user input and puts it into an array
             char[] charArray = s.ToCharArray();
            //reverses the array.
             Array.Reverse(charArray);
            //prints out the result.
            Console.WriteLine(charArray);
              
            

        }
    }
}
