using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncInhPol
{
    public class Person
    {

        //3.1.1

        //public int Age
        //{
        //    get { return age; }
        //    set { age = value; }
        //}

        //public string FName
        //{
        //    get { return fName; }
        //    set { fName = value; } 
        //}

        //public string LName
        //{
        //    get { return lName; }
        //    set { lName = value; } 
        //}

        //public double Height
        //{
        //    get { return height; }
        //    set { height = value; }
        //}
        //public double Weight
        //{
        //    get { return weight; }
        //    set { weight = value; }
        //}




        //when instantaiate a person in Program.cs I dont have direct access to"age"just to "Age"



        private int age;
        public int Age
        {
            get { return age; }
            set 
            {
                if (value > 0)
                    age = value;
                else
                    throw new ArgumentException("Age should be more then 0");
                }
        }


        private string fName;
        public string FName
        {
            get { return fName; }
            set
            {
                if (value.Length > 2 && value.Length < 11 && !string.IsNullOrEmpty(value))
                {
                    fName = value;
                }
                else
                    throw new ArgumentException("fName should be longer then 2 charater and shorter then 10 character");


            }
        }

        private string lName;
        public string LName
        {
            get { return lName; }
            set {
                if (value.Length > 3 && value.Length <16 && !string.IsNullOrEmpty(value))
                {
                    lName = value;
                }
                else
                    throw new ArgumentException("lName should be longer then 3 charater and shorter then 15 character");


            }
        }
               
        
        private double height;  
        public double Height
        {
            get { return height; }
            set { height = value; }
        }


        private double weight;
        public double Weight
        {
            get { return weight; }
            set { weight = value; }
        }


    }

}
