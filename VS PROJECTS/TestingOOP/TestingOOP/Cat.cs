using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingOOP
{
    public class Cat
    {
        //Field name
        private string name;
        //Field color
        private string color;

        public string Name
        {
            //Getter of the property "Name"
            get
            {
                return this.name;
            }
            //Setter of the property "Name"
            set
            {
                this.name = value;
            }
        }

        public string Color
        {
            // Getter of the property "Color"
            get
            {
                return this.color;
            }
            // Setter of the property "Color"
            set
            {
                this.color = value;
            }
        }

        // Defaut constructor
        public Cat()
        {
            this.name = "Unnamed";
            this.color = "Gray";
        }

        // Constructor with parameters
        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        // Method say Miau

        public void SayMiau()
        {
            Console.WriteLine("Cat {0} say Miau !", name);
        }
    }
}
