using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TestingOOP
{
    

    class TestingTheAnimals
    {
        static void Main(string[] args)
        {
            Cat firstCat = new Cat();
            firstCat.Name = "Tonny";
            firstCat.SayMiau();

            Cat secondCat = new Cat("Pesho", "red");
            secondCat.SayMiau();
            Console.WriteLine("The cat {0} is {1} !", secondCat.Name , secondCat.Color);

            Dog firstDog = new Dog();
            firstDog.SayBau();

            Dog secondDog = new Dog("Sharo", "Ulichna-prevazhodna", 4);
            Console.WriteLine("The dog {0} which is from the breed {1} is {2} years old.",secondDog.Name,secondDog.Breed,secondDog.Age);

            Dog thirdDog = new Dog("Cezar");
            Console.WriteLine(thirdDog.Name);
            

        }
    }
}
