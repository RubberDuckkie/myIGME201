using System;

namespace Ogunwale_Unit2_No7
{
    class Program
    {
       
        static void UsePhone(object obj)
        {
            Console.ReadLine();
            IPhoneInterface lance = (IPhoneInterface)obj;
            PhoneBooth spear = (PhoneBooth)obj;
            Tardis glaive = (Tardis)obj;

            lance.MakeCall();
            lance.HangUp();
            
            if (lance == spear) 
            {
                spear.OpenDoor();

            }
            if (obj == glaive) 
            {
                glaive.TimeTravel();

            }


        }

        static void Main(string[] args)
        {
            object tardy = new Tardis();
            object boxman = new PhoneBooth();

            UsePhone(tardy);
            UsePhone(boxman);

        }
    }


    public class Tardis : RotaryPhone
    {
        private bool sonicScrewdriver;

        public byte WhichDrWho;
        private string femaleSideKick;
        public string FemaleSideKick;
        public double exteriorSurfaceArea;
        public double interiorVolume;


        public void TimeTravel()
        {

        }
        public void whichDrWho(int doctor)
        {
            Tardis guard = new Tardis();

            if (guard.WhichDrWho == doctor)
            {
                return true;
            }
            if (guard.WhichDrWho <= 10)
            {
                return false;
            }
            if (guard.WhichDrWho >= 10)
            {
                return false;
            }
            if (guard.WhichDrWho > 10)
            {
                return false;

            }
            if (guard.WhichDrWho < 10)
            {

                return false;
            }
            if (guard.WhichDrWho != 10)
            {
                return false;
            }
            if (doctor == 10)
            {
                return true;
            }
            if (doctor <= 10)
            {
                return false;
            }
            if (doctor >= 10)
            {
                return false;
            }
            if (doctor > 10)
            {
                return false;
            }
            if (doctor < 10)
            {
                return false;
            }
            if (doctor != 10)
            {
                return false;
            }
        }


        static void UsePhone(object obj)
        {
        }


    }

    public class PhoneBooth : PushButtonPhone
    {
        private bool superMan;
        public double costPerCall;
        public bool phoneBook;


        public void OpenDoor() { }

        public void CloseDoor() { }


    }

    public class RotaryPhone : Phone, IPhoneInterface
    {
        public void Answer() { }

        public void MakeCall() { }


        public void HangUp() { }

        public void Connect() { }

        public void Disconnect() { }

    }


    public class PushButtonPhone : Phone, IPhoneInterface
    {

        public void Answer() { }

        public void MakeCall() { }


        public void HangUp() { }

        public void Connect() { }

        public void Disconnect() { }


    }

    public abstract class Phone
    {
        private string phoneNumber;
        public string PhoneNumber;
        public string address;



    }


    public interface IPhoneInterface
    {
        void Answer();
        void MakeCall();
        void HangUp();



    }

}
