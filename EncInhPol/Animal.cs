using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncInhPol
{
    public abstract class Animal
    {

        //3.3.1
        //3.3.2


        private int age;
        public int Age
        {
            get { return age; }
            set { age = value; }        
        }

        //public int Age { get; set; }

        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        //public string Name { get; set; }

        private double weight;
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        //public double Weight { get; set; }    

  
        //
     

    
        //3.3.3
        public abstract void DoSound();

        //3.3.4
        public Animal(string name, double weight, int age)
        {

            this.Name = name;
            this.Weight = weight;
            this.Age = age;
        }


        //3.4.1
        public virtual string Stats()
        {
            return $"N:{Name}, W: {Weight}, A: {Age}";
        }
    }




    //3.3.5
    //3.3.6
    //3.3.7

    public class Horse : Animal
        {
            public int MaxSpeed { get; set; }

        public override void DoSound()
        {
            Console.Write("Horsesound");
        }

        public Horse (string name, double weight, int age, int maxSpeed):base(name,weight,age)
        { 
            this.MaxSpeed = maxSpeed;
        }
       

        public override string Stats()
        {
            return $"{base.Stats()},Maxspeed: {MaxSpeed}";
        }
    }
    public class Dog : Animal
    {
        public bool  IsFluffy { get; set; }

        public override void DoSound()
        {
            Console.Write("woof");
        }

        public Dog(string name, double weight, int age, bool isFluffy) : base(name, weight, age)
        {
            this.IsFluffy = isFluffy;
        }

      

        public override string Stats()
        {
            return $"{base.Stats()},fluffy: {IsFluffy}";
        }

        //3.4.15
        public string OptionalMethod()
        {
            return "what a beautiful dog";
        }
    }
    public class Hedgehog : Animal
    {
        public int NrOfSpikes { get; set; }

        public override void DoSound()
        {
            Console.Write("HedgehogSound");
        }

        public Hedgehog (string name, double weight, int age, int nrOfSpikes) : base(name, weight, age)
        {
            this.NrOfSpikes = nrOfSpikes;
        }

       

        public override string Stats()
        {
            return $"{base.Stats()},nr of spikes: {NrOfSpikes}";
        }
    }
    public class Worm : Animal
    {
        public bool IsPoisounous { get; set; }

        public override void DoSound()
        {
            Console.Write("wor");
        }


        public Worm(string name, double weight, int age, bool isPoisounous) : base(name, weight, age)
        {
            this.IsPoisounous = isPoisounous;
        }

        
        public override string Stats()
        {
            return $"{base.Stats()},IsPoisounous: {IsPoisounous}";
        }
    }

    public class Bird : Animal
    {
        public double WingSpan { get; set; }

        public override void DoSound()
        {
            Console.Write("whistles");
        }


        public Bird (string name, double weight, int age, double wingSpan) : base(name, weight, age)
        {
            this.WingSpan = wingSpan;
        }
      

        public override string Stats()
        {
            return $"{base.Stats()},WingSpan: {WingSpan}";
        }

    }

    public class Wolf : Animal
    {
        public bool IsAttacking { get; set; }

        public override void DoSound()

        {
            Console.Write("howl");
        }

        public Wolf(string name, double weight, int age, bool isAttacking) : base(name, weight, age)
        {
            this.IsAttacking = isAttacking;
        }

       

        public override string Stats()
        {
            return $"{base.Stats()},IsAttacking: {IsAttacking}";
        }

    }

    //3.3.8
    //3.3.9

    public class Swan : Bird
    {
        public bool  isLivingInNearestLake { get; set; }
        public override void DoSound()

        {
            Console.Write("SwanSound");
        }


        public Swan(string name, double weight, int age, int wingSpan, bool isLivingInNearestLake) : base(name, weight, age, wingSpan)
        {
            this.isLivingInNearestLake = isLivingInNearestLake;
        }
    }
    public class Flamingo : Bird
    {
        public string exactColorOfFlamingo { get; set; }
        public override void DoSound()

        {
            Console.Write("flamingoSound");
        }


        public Flamingo(string name, double weight, int age, int wingSpan, string exactColorOfFlamingo) : base(name, weight, age, wingSpan)
        {
            this.exactColorOfFlamingo = exactColorOfFlamingo;
        }
    }
    public class Pelican : Bird
    {
        public int maxNumberOfEatenFish { get; set; }
        public override void DoSound()

        {
            Console.Write("PelicanSound");
        }


        public Pelican(string name, double weight, int age, int wingSpan, int maxNumberOfEatenFish) : base(name, weight, age, wingSpan)
        {
            this.maxNumberOfEatenFish = maxNumberOfEatenFish;
        }
        public override string Stats()
        {
            return $"{base.Stats()},maxNumberOfEatenFish: {maxNumberOfEatenFish}";
        }
    }

        //3.3.10
        public interface IPerson
        {
            void Talk();

        }

       
    // 3.3.11
        public class Wolfman : Wolf, IPerson
        {
            public Wolfman(string name, double weight, int age, bool isAttacking) : base (name, weight, age, isAttacking) { }

        //3.3.12
            public void Talk()
            {
                Console.WriteLine("wolfman Talk");
            }

            public override void DoSound()

            {
                Console.Write("WolfmanSound");
            }

            public override string Stats()
            {
                return $"{base.Stats()}";
            }
        //3.3.14
        //ett nytt attribut ska lägga i Bird class
        //3.3.15
        //nya attributet ska läggga i Animal class
        }    
    }

 

