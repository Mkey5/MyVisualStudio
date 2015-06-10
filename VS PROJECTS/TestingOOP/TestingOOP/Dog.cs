using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingOOP
{
    class Dog
    {
        
        private string name;
        private string breed;
        private int age;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Breed
        {
            get
            {
                return this.breed;
            }
            set
            {
                this.breed = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        // Default
        public Dog()
        {
            this.name = "Rex";
            this.breed = "Samovodska Prewyzhodna";
            this.age = 3;
        }

        // Constructor with name , bree and age
        public Dog(string name, string breed, int age)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
        }

        // Constructor with only name 
        public Dog(string name)
        {
            this.name = name;
        }

        // Method barking
        public void SayBau()
        {
            Console.WriteLine("The dog {0} says : Bau Bau !",name);
        }

    }
}
