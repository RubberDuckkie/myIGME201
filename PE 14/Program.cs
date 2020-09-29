using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Ogunwale_PE_14_No3
{



    class Program 
    {
        static void Main(string[] args)
        {
            Warrior warri = new Warrior();
            Gunbreaker gung = new Gunbreaker();
            MyMethod(warri);
            Console.WriteLine(" ");
            MyMethod(gung);
            Console.WriteLine(" ");
        }


        public static void MyMethod(object myObject){
            ITank tank = (ITank)myObject;
            tank.Shirk();
            tank.TankStance();
            tank.DamageReduction();


        }
        


    }

   
    public class Warrior : ITank {


        public void Shirk() {
            Console.WriteLine("It's time for you to take the agrro!");
        }

        public void TankStance() {
            Console.WriteLine("Defiance is my Tank Stance!");
        }

        public void DamageReduction() {
            Console.WriteLine("By using Vengance, i can lower damage tanken by 30% and deal 30% back as damage!!");
        }
      
    }


    public class Gunbreaker : ITank {

        public void Shirk() {
            Console.WriteLine("Im passing you the boss for now!");
        }

        public void TankStance() {
            Console.WriteLine("Im Using Royal Guard, my Tank Stance");
        }

        public void DamageReduction() {
            Console.WriteLine("By using Nebula and Camouflage, I can reduce damage by 30%, parry incoming attacks and reduce damage by another 10%");
        }

    }

    interface ITank {

        void Shirk();

        void TankStance();

        void DamageReduction();
    
    
    }















}
