using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Inheritance
{
    public class Animals
    {
        public int LegCount { get; set; }
        public int EyeCount { get; set; }
        public string Diet { get; set; }
        public bool IsMammal { get; set; }
    }
    public class Bird : Animals
    {
        public int AvgWingspan { get; set; }
        public bool NightActive { get; set; }
        public string Color { get; set; }
        public bool CanFly { get; set; }
    }
    public class Reptile : Animals
    {
        public bool Venomous { get; set; }
        public bool MultiColored { get; set; }
        public string Habitat { get; set; }
        public int PowerLevel { get; set; }
    }

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


            Bird falcon = new Bird();
            falcon.AvgWingspan = 31;
            falcon.CanFly = true;
            falcon.Color = "brown";
            falcon.Diet = "carnivore";
            falcon.EyeCount = 2;
            falcon.LegCount = 2;
            falcon.IsMammal = false;
            falcon.NightActive = false;

            Reptile kDragon = new Reptile();
            kDragon.EyeCount = 2;
            kDragon.LegCount = 4;
            kDragon.IsMammal = false;
            kDragon.Diet = "carnivore";
            kDragon.MultiColored = false;
            kDragon.PowerLevel = 9001;
            kDragon.Venomous = true;
            kDragon.Habitat = "land";



            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Console.WriteLine($"The falcon has {falcon.LegCount} legs, {falcon.EyeCount} eyes, and is a {falcon.Diet}.");
            Console.WriteLine($"To say it is a mammal would be {falcon.IsMammal}.  It's average wingspan is somewhere around {falcon.AvgWingspan} inches.");
            Console.WriteLine($"it's feathers are a nice {falcon.Color} hue and it would be {falcon.CanFly} to say it can fly.");
            Console.WriteLine($"it would be {falcon.NightActive} to say the falcon prefers the night.");
            Console.WriteLine("\n \n");
            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Console.WriteLine("WILDLIFE FACT? FILE");
            Console.WriteLine("K.Dragon");
            Console.WriteLine($"Number of eyes: {kDragon.EyeCount}");
            Console.WriteLine($"Habitat: {kDragon.Habitat}");
            Console.WriteLine($"Multicolored: {kDragon.MultiColored}");
            Console.WriteLine($"Venomous: {kDragon.Venomous}");
            Console.WriteLine($"Diet: {kDragon.Diet}");
            Console.WriteLine($"Number of legs: {kDragon.LegCount}");
            Console.WriteLine($"Is a mammal: {kDragon.IsMammal}");
            Console.WriteLine($"Powerlevel: {kDragon.PowerLevel}");
            Console.WriteLine("WhaT!?!? 9000!!");
        }
    }
}
