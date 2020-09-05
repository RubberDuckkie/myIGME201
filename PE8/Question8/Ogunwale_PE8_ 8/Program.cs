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
        {
            Console.WriteLine("Give me a string, and ill replace any no with a yes: ");
            string userString = Console.ReadLine();
            char[] charArray = userString.ToCharArray();
            string replaceString = userString.Replace("no", "yes");
            Console.WriteLine("Here is your replaced String!");
            Console.WriteLine(replaceString);

        }
    }
}
