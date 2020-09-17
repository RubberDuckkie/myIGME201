using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Ogunwale_Unit1_No12
{
    class Program
    {
        static void Main(string[] args)
        {
            string sName;
            double dSalary = 30000;


            Console.WriteLine("Give me your username!: ");
            sName = Console.ReadLine();

            static  bool GiveRaise(string name, ref double salary) {
                if (name == sName)
                {
                    return true;
                    salary = dSalary + 19999.99;
                    Console.WriteLine("Congratulations! Your salary has increased by $19,999.99!! your new salary is: $" + salary);
                }
                else {
                    return false;
                
                }
            
            }

        }
    }
}
