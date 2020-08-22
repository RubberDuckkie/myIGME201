using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogunwale_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is just a number I decied to come up with.
            object zan = 8;
            //I wanted to see what dark yellow would look like on the command prompt.
            Console.ForegroundColor =
                ConsoleColor.DarkYellow;
            //Part of the assignment.
            Console.WriteLine("Did you know? In Final Fantasy XIV, the Monk Class has references to Bhuddism and other Eastern Religions!");
            //How I felt today.
            Console.WriteLine("Today feels like : " + zan);
        }
    }
}
