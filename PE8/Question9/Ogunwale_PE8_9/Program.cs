using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogunwale_PE_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //prompts the user for a string
            Console.WriteLine("Give me a string, and I'll fill it with quotes!: ");
            string quo = Console.ReadLine();
            //splits each of the spaces
            string[] wordSet = quo.Split(' ');
            //the fpreach loop to print all the words in the array
            foreach (string word in wordSet)
            {   //Puts all the words on a new line
                Console.WriteLine("\"" + word + "\"");
            }
        }
    }
}
