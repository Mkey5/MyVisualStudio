using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForTheDog
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

        // Constructor
        public Dog(string name, string breed, int age)
        {
            this.name = name;
            this.breed = breed;
            this.age = age;
        }

        // Method barking
        public void SayBark()
        {
            Console.WriteLine("The dog {0} says : Bau Bau !",name);
        }

    }
}
