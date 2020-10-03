using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ogunwale_PE_15
{
    public class Class1
    {
    }

    public abstract class HotDrink {
        public bool instant;
        public bool milk;
        private byte sugar;
        public string size;

        public virtual int AddSugar(byte amount) {

            throw new NotImplementedException();
        }

        public abstract string Steam();
        public HotDrink(string brand) {

        }

    }


    public interface ITakeOrder {

       public void TakeOrder();

    }

    public interface IMood {

        string Mood { get; }

    }

    public class CupOfCoffee : HotDrink, ITakeOrder {
        public string beanType;
        

        public override string Steam()
        {
            throw new NotImplementedException();

        }

        
        CupOfCoffee(string brand): base(brand) { 
        
        
        }
        
        
    }

    public class CupOfTea : HotDrink {

        public string leafType;
        public override string Steam()
        {
            throw new NotImplementedException();
        }

        CupOfTea(bool customerIsWealthy) {
            throw new NotImplementedException();
        }
    }



    public class CupOfCocoa : HotDrink {

        public static int numCups;
        public bool marshmellows;
        private string source;

        public string Source { get; }

        public override string Steam()
        {
            throw new NotImplementedException();
        }

        public override int AddSugar(byte amount)
        {
            return base.AddSugar(amount);
        }

        CupOfCocoa(bool marshmellows): base ("Expensive Organic Brand") {     
        }



    }

    public class Customer : IMood {
        public string name;
        public string creditCardNumber;

        public string Mood { get; }
    
    }


    public class Waiter : IMood {
        public string name;

        public string Mood { get; }

        public void ServeCustomer(HotDrink cup) { 
        
        }




    }

}
