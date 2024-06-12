using System;

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

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class

            Bird eagle = new Bird();

            eagle.Beak = true;
            eagle.Wings = true;
            eagle.LayEggs = true;
            eagle.NestMaterials = "Sticks";
            eagle.diet = "Small Prey";


            Reptile cobra = new Reptile();

            cobra.ColdBlooded = true;
            cobra.NoLegs = true;
            cobra.Venemous = true;
            cobra.scales = true;
            cobra.diet = "Small Prey";

            Console.WriteLine();
            Console.WriteLine("Cobra Qualities:");
            cobra.PrintReptile();

            Console.WriteLine();
            Console.WriteLine("Eagle Qualities:");
            eagle.PrintBird();

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
