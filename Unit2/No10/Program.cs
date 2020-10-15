using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogunwale_Unit2_No10
{
    class Program
    {
        static void Main(string[] args)
        {
            Monk Loft = new Monk
            Paladin Minerva = new Paladin
            Describer(Loft);
            Describer(Minerva);
        }
    }


    static void Describer(object obj) 
    {
        IMeleeDPS fist = (IMeleeDPS)obj
        fist.Description();        
    }


    public abstract class Character
    {
        public string race;
        public string forename;
        private readonly string surname;

        public void Attack() { }
        public void Defend() { }
        public abstract void Emote();
        public virtual void Dance() { }

    }

    public interface IMeleeDPS
    {
        void Rotation();
        void GapCloser();
        void Positional();
        void Description();

    }


    public interface ITank
    {
        void DmgReduct();
        void TankStance();
        void Shirk();
        void Description();

    }

    public class Monk : IMeleeDPS
    {

        public int chakra;
        public int gLightning;
        public bool fChakra;


        public void Rotation()
        {
            Console.WriteLine("My Rotation is: Dragon Kick, Twin Snakes and Demolish!");
        }

        public void GapCloser()
        {
            Console.WriteLine("My Gap Closer is Shoulder Tackle!");
        }

        public void Positional()
        {
            Console.WriteLine("Almost all of my moves require me to be in a position thats away from the boss!");
        }
        public static void Flip()
        {
            Console.WriteLine("You have sucessfully done one flip.");

        }

        public void Description()
        {
            Console.WriteLine("The monks comprised an order known as the Fist of Rhalgr, and it was to this god—the Destroyer—that they devoted their lives of worship. " +
                "By mastering seats of power within the body known as chakra, they are capable of performing extraordinary physical feats.");
        }


    }


    public class Paladin : ITank
    {
        public bool pOfArms;
        public bool holyGround;
        public bool sentinal;

        public void DmgReduct()
        {
            Console.WriteLine("My main damage reduction is the use of Sentinal and Sheltron!");
        }

        public void TankStance()
        {
            Console.WriteLine("My Tank Stance is Iron Will!");
        }

        public void Shirk()
        {
            Console.WriteLine("While this is a universal tank skill its still important to use.");

        }

        public static void Crouch()
        {
            Console.WriteLine("By crouching down, you see the road you walk upon, and how tretcherous it has become");

        }

        public void Description()
        {
            Console.WriteLine("Clad in brilliant silver armor, they charge fearlessly into battle, " +
                "ever ready to lay down their lives for their liege. To be a paladin is to protect, " +
                "and those who choose to walk this path will become the iron foundation upon which the party's defense is built.");


        }
    }


    public class Loft_Hirian : Character
    {
        public void Breakdance()
        {
            Console.WriteLine("Im a casual breakdancer, a hobby but part of my character!");
        }

        public override void Emote()
        {
            throw new NotImplementedException();
        }
    }

    public class Minerva_Hirian : Character
    {
        public void Waltz()
        {
            Console.WriteLine("Ballroom Dancing with Loft is an experience, but a fun one.");
        }



        public override void Emote()
        {
            Console.WriteLine("Drinking Water is my base emote");
        }
    }

}
