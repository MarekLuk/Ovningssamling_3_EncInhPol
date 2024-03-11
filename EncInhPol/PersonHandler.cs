using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncInhPol
{
    public class PersonHandler
    {

        //3.1.2
        public void SetAge(Person person , int age)
        {
            person.Age = age;
        }
        //3.1.3
        public Person CreatePerson(int age, string fname, string lname, double height, double weight) 
        {
                Person person= new Person { Age=age, FName=fname, LName=lname, Height=height, Weight=weight};
                 return person;
        }

        public void ShowFullName(Person person )
        {
            
            Console.WriteLine($"Full name is {person.FName} {person.LName} and {person.Age} old");
        }

        //public double  CalculateBMI(Person person) 
        //{
        //    double bmi=person.Weight/(person.Height*person.Height);
        //    return Math.Round(bmi,2);
        //}

        //3.1.4
        public void  CalculateBMI(Person person)
        {
            double bmi = person.Weight / (person.Height * person.Height);
            Console.WriteLine($" {person.FName} {person.LName} has BMI of {Math.Round(bmi, 2)}");
           
        }

        public void PersonCategorizer(Person person) 
        {
            if (person.Age <12)
            {
                Console.WriteLine($"{person.FName} {person.LName} is Child");
            }
            else if (person.Age>=12&& person.Age<=19)
            {
                Console.WriteLine($"{person.FName} {person.LName} is Teen");
            }
            else if (person.Age >= 19 && person.Age <= 64)
            {
                Console.WriteLine($"{person.FName} {person.LName} is Adult");
            }
            else {
                Console.WriteLine($"{person.FName} {person.LName} is Senior");
            }


        }


    }
}
