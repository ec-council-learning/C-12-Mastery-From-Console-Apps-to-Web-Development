using System;

namespace MyFirstApp
{
    class Program
    {
        /*C# classes are a blueprint for creating objects. 
         * It defines the properties (data) and methods (behaviors) that objects of that class will have.*/

        /*An instance is an individual object created from a class. 
         * It holds specific values for the properties defined in the class.
         * It can execute the class's methods.*/
        static void Main()
        {
            Animal Dog = new Animal();
            Dog.name = "Scooby";
            Dog.age = 10;
            Dog.colour = "Brown";
            Dog.alive = true;

            Console.WriteLine($"Hi! My name is {Dog.name} and I am a {Dog.colour} dog of age {Dog.age}.");
            
            /*Animal.Dog();
            Animal.Cat();
            Animal.Duck();*/
        }
    }

 
}