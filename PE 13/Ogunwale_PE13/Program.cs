using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ogunwale_PE13
{
    class Program
    {
        static void Main(string[] args)
        {

            Pet thisPet; 
            Dog dog = new Dog();
            Cat cat = new Cat();
            IDog iDog = new IDog();
            ICat iCat = new ICat();
            Pets pets = new Pets();
            Random rand = new Random();

            for (int x = 0; x > 51; x++)
            {

                if (rand.Next(1, 11) == 1)
                {
                    // 50% chance of adding a dog
                    if (rand.Next(0, 2) == 0)
                    {
                        dog.Add(dog);
                    }
                    else
                    {
                        // else add a cat
                        cat.Add(cat);
                    }

                }
                else {

                    thisPet = pets.petList;
                
                }



            }

        }

        public class Pets
        {
            public List<Pet> petList = new List<Pet>();


            int Count { get; }

            public Pet this[int nPetEl]
            {
                get
                {
                    Pet returnVal;
                    try
                    {
                        returnVal = (Pet)petList[nPetEl];
                    }
                    catch
                    {
                        returnVal = null;
                    }
                    return (returnVal);
                }

                set
                {
                    // if the index is less than the number of list elements
                    if (nPetEl < petList.Count)
                    {
                        // update the existing value at that index
                        petList[nPetEl] = value;
                    }
                    else
                    {
                        // add the value to the list
                        petList.Add(value);
                    }
                }
            }

            public void Add(Pet pet) {
                petList.Add(pet);
            }

            public void Remove(Pet pet) {
                petList.Remove(pet);
            }

            public void RemoveAt(int nPetEl) {
                petList.RemoveAt(nPetEl);
            }
        }

        public abstract class Pet : Pets
        {
            internal string name;
            public int age { get; set; }
            public string Name;

            public Pet()
            {

            }


            public Pet(string name, int age)
            {
                this.name = Name;
                this.age = age;
            }

            public abstract void Eat();

            public abstract void Play();

            public abstract void GotoVet();


        }

        public class Dog : Pet, IDog
        {
            public string license;


            public override void Eat()
            {
                Console.WriteLine(this.Name + "Oh Boy! Ill Eat Anything!");
            }

            public override void Play()
            {
                Console.WriteLine(this.Name + "Playtime is the best time!");
            }

            public void Bark()
            {
                Console.WriteLine(this.Name + "BOERK");
            }

            public void NeedWalk()
            {
                Console.WriteLine(this.Name + ": Walk Tiem!");
            }

            public override void GotoVet()
            {
                Console.WriteLine(this.Name + "Nonononono! Please dont bring meee!!");
            }

            public Dog(string szLicense, string szName, int nAge) : base(szName, nAge)
            {

            }
            public Dog()
            {

            }


        }

        public class Cat : Pet, ICat
        {
            public override void Eat()
            {
                Console.WriteLine(this.Name + "Where's My Meow Mix?");
            }
            public override void Play()
            {
                Console.WriteLine(this.Name + "Catnip and toys? Oh my!");
            }
            public void Purr()
            {
                Console.WriteLine(this.Name + "Purrrrrrrrrrrrrr");
            }
            public void Scratch()
            {
                Console.WriteLine(this.Name + "Bad Touch!!");
            }
            public override void GotoVet()
            {
                Console.WriteLine(this.Name + "No! I'm Not Going!!");
            }

            public Cat()
            {

            }

        }

        public interface IDog
        {
            void Eat();
            void Play();
            void Bark();
            void NeedWalk();
            void GotoVet();
        }

        public interface ICat
        {
            void Eat();
            void Play();
            void Scratch();
            void Purr();
        }

    }
}





