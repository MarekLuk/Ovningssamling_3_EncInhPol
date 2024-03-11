using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static EncInhPol.Pelican;

namespace EncInhPol
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //instance of Person
            //Person person31 = new Person
            //{
            //    Age = 81,
            //    FName = "Olaf",
            //    LName = "Carlsson",
            //    Height = 181.5,
            //    Weight = 77

            //};
            //Console.WriteLine(person31.Age);


            //3.1.5
            PersonHandler handler = new PersonHandler();
            var examplePerson = handler.CreatePerson(18, "Oskar", "Olson", 1.75, 75);
            var examplePerson2 = handler.CreatePerson(78, "Liam", "MacDam", 1.92, 85);
            var examplePerson3 = handler.CreatePerson(7, "Sara", "Ricardo", 1.10, 30);

            List<Person> listOfPeolpe = new List<Person> { examplePerson, examplePerson2, examplePerson3 };

            foreach (var item in listOfPeolpe)
            {
                //handler.SetAge(item, item.Age + 1);
                handler.CalculateBMI(item);
                handler.ShowFullName(item);
                handler.PersonCategorizer(item);
                
                Console.ReadLine();
            }




            //handler.CalculateBMI(examplePerson);
            //handler.CalculateBMI(examplePerson2);
            //handler.CalculateBMI(examplePerson3);

            //Person person = new Person();
            //PersonHandler handler = new PersonHandler();

            //handler.SetAge(person, 18);
            //Console.WriteLine(person.Age);
            //Console.ReadLine();


            //Console.WriteLine(person.Age);
            //Console.ReadLine();


            try
            {


                //3.2.7
                List<UserError> userErrors = new List<UserError>();
                userErrors.Add(new NumericInputError());
                userErrors.Add(new TextInputError());
                userErrors.Add(new NumericInputError());
                userErrors.Add(new TextInputError());
                userErrors.Add(new NumericInputError());
                userErrors.Add(new TextInputError());

                //3.2.8
                foreach (var item in userErrors)
                {
                    Console.WriteLine($"{item.UEMessage()}\n\n");
                }

                //3.2.9
                //3.2.10
                //tre egna klasser

                List<UserError> ownUserErrors = new List<UserError>();
                ownUserErrors.Add(new ExcessInputError());
                ownUserErrors.Add(new WrongInputError());
                ownUserErrors.Add(new TooShortInputError());
                ownUserErrors.Add(new ExcessInputError());
                ownUserErrors.Add(new WrongInputError());
                ownUserErrors.Add(new TooShortInputError());

                foreach (var item in ownUserErrors)
                {
                    Console.WriteLine($"{item.UEMessage()}");
                }


                foreach (var person in listOfPeolpe)
                {
                    handler.PersonCategorizer(person);
                }
                








                //3.4.3
                //3.4.4
                List<Animal> animals = new List<Animal>
        {
                new Horse("HorseName", 500, 5, 45),
                new Hedgehog("HedgehogName", 2, 15, 1001),
                new Pelican("PelicanName", 15.2,2,1,20),
                new Wolfman("Wolfman",22.2, 14, true),
                new Dog("Rex", 10.5, 15, true),
                new Dog("Tabi", 7.5, 7, false),

        };



                //}
                //3.4.5
                //3.4.6                
                //foreach (var item in animals)
                //{

                //    Console.WriteLine($"{item.GetType().Name}\n");
                //    Console.WriteLine(item);
                //    item.DoSound();

                //}

                //3.4.7

                foreach (var item in animals)
                {
                    if (item is IPerson patternmatching)
                    {
                        patternmatching.Talk();
                    }
                    else
                    {
                        Console.WriteLine($"{item.GetType().Name}\n");
                        item.DoSound();
                        Console.ReadLine();

                    }
                }



                    //Console.WriteLine(item.optionalMethod());
                    //int his casae teLine(patternmatching.optionalMethod());
                    //acctualy optional method works does not work




                    //3.4.8
                    List<Dog> dogs = new List<Dog>
                {

                    new Dog("GUA",24.5,12,true),
                    new Dog("Dar",12.2,10,true),
                    };
                    //3.4.9
                    //new Horse("horsename", 100.5,1,50);
                    //Det funkar inte därfor det Horse är inte samma typ som Dog
                    //3.4.10
                    //Det ska bli Animal typ

                    //3.4.11

                     foreach (var item2 in animals)
                    {
                                             
                           Console.WriteLine(item2.Stats());
                

                           Console.ReadLine();

                        //3.4.13
                        //iterete through list animals and  Stats() method is called
                        //ReadLine as helper
                       
                    }

                //3.4.14
                foreach (var item in animals)
                {
                    if (item is Dog patternmatching)
                    {
                        Console.WriteLine(patternmatching.Stats());
                        Console.WriteLine(patternmatching.OptionalMethod());


                        Console.ReadLine();
                    }
                    else
                    {
                        //gör inte att göra
                        //Console.WriteLine(item.OptionalMethod());
                    }

                    //3.4.16
                    //Nej, OptionalMethod() is specific just to a Dog class and not to animal object






                    Console.ReadLine();




                }
                }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }


         



       


        }
        
    }
}
