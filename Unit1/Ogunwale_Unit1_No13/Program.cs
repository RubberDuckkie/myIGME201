using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogunwale_Unit1_No13
{
    class Program
    {
        struct employee
        {
            public string sName;
            public double dSalary;
        }

        static void Main(string[] args)
        {



        }

        static bool GiveRaise(string name, ref double salary)
        {
            employee x;
            if (name == x.sName)
            {
                return true;
                salary = x.dSalary + 19999.99;
                Console.WriteLine("Congratulations! Your salary has increased by $19,999.99!! your new salary is: $" + salary);
            }
            else
            {
                return false;

            }
        }
    }
}
