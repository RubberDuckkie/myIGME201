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
             Console.WriteLine("Give me a string, and ill reverse it!: ");
             string s = Console.ReadLine();
            Console.WriteLine("Reverse, Reverse!");
             char[] charArray = s.ToCharArray();
             Array.Reverse(charArray);

            Console.WriteLine(charArray);
              
            

        }
    }
}
