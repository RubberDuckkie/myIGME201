using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogunwale_Unit2_No4
{

    public class Tardis : RotaryPhone{
        private bool sonicScrewdriver;
        private byte whichDrWho;
        public readonly byte WhichDrWho;
        private string femaleSideKick;
        public readonly string FemaleSideKick;
        public double exteriorSurfaceArea;
        public double interiorVolume;


        public void TimeTravel() { 
        
        }

       


    }


    public class PhoneBooth : PushButtonPhone {
        private bool superMan;
        public double costPerCall;
        public bool phoneBook;


        public void OpenDoor() { }

        public void CloseDoor() { }
        
    
    }

    public class RotaryPhone : Phone, PhoneInterface
    {
        public void Answer() { }

        public void MakeCall() { }


        public void HangUp() { }

        public void Connect() { }

        public void Disconnect() { }
        
    }


    public class PushButtonPhone : Phone, PhoneInterface {

        public void Answer() { }

        public void MakeCall() { }


        public void HangUp() { }

        public void Connect() { }

        public void Disconnect() { }


    }

    public abstract class Phone  {
        private string phoneNumber;
        public string PhoneNumber;
        public string address;

    
        
    }


    public interface PhoneInterface {
        void Answer();
        void MakeCall();
        void HangUp();
        
    
    
    }









}
