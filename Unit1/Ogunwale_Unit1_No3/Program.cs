using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogunwale_Unit1_No3
{
    class Program
    {
        //creates a delegate
        public delegate string ReadingLine();
        static void Main(string[] args)
        {
            //this is the variable of delegate 
            ReadingLine printing;

            //now, to construct the delegate function
            printing = new ReadingLine(Console.ReadLine);

            //and finally, to call the delegate function
            string readString = printing();

        }
    }
}
