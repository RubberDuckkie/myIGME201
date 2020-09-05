using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogunwale_PE8
{
    class Program
    {
        static void Main(string[] args)
        {
            //set z to double
            double z = 0.0;
            //the x increment formula
            for (double x = -1; x <= 1; x += 0.1) {
                //the y increment formula
                for (double y = 1; y <= 4; y += 0.1) {
                    //the Z formula
                    z = (3 * Math.Pow(y, 2)) + (2 * x) - 1;
                    //prints out the results
                    Console.WriteLine(z);
                }
                //new space
                Console.WriteLine("\n");
            }
            

        }
    }
}
