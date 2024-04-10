
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class


            Bird Robin = new Bird()
            {
                
                Eyes = 2,
                MaleOrFemale  =  "Male",
                BodySize = "Small",
                Age = 3
                
           };

            Reptile Rep = new Reptile()
            {
                Eyes = 2,
                MaleOrFemale = "Female",
                BodySize = "Small",
                Age = 5,
                HasClaws = true,
                IsItColdBlooded = true,
               DoesItLayEggs = true,
               NumberOfLegs = 2

            };

            List <Animal> AnimalsInVet = new List<Animal>();

            AnimalsInVet.Add(Robin);
            AnimalsInVet.Add(Rep);

            Console.WriteLine("Please select Patient");
            var userInput = Console.ReadLine();
            if (userInput.ToLower() == "rep")
            {
                Rep.Details();
            }
            else if (userInput.ToLower() == "robin")
            {
                Robin.Details();
            }

          
           

           
            

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            
        }

       
    }
}
