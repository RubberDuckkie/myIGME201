using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogunwale_PE8__8
{
    class Program
    {
        static void Main(string[] args)
        {   //Takes the user input and replaces every no with a yes
            Console.WriteLine("Give me a string, and ill replace any no with a yes: ");
            //reads the user input
            string userString = Console.ReadLine();
            //takes everything into the array
            char[] charArray = userString.ToCharArray();
            //replaces every no in the string with a yes
            string replaceString = userString.Replace("no", "yes");
            //presents the replaced string.
            Console.WriteLine("Here is your replaced String!");
            Console.WriteLine(replaceString);

        }
    }
}
