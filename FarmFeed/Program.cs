// imports
using System;
using System.Collections.Generic;

namespace FarmFeeding
{
    class Program
    {
        // Global variables
        List<string> species = new List<string>() { "Romeney", "KuneKune", "Angus", "Leghorn" };
        List<string> food = new List<string>() { "300g", "2500g", "10886g", "125g" };
        static int Flag = 0;

        // Methods and/or function

        // Check to see if an interger enter by a user is within range
        static int CheckSpecies(string question, int min, int max)
        {
            Console.WriteLine(question);

            while (true)
            {
                try
                {

                    int userInt = Convert.ToInt32(Console.ReadLine());

                    if (userInt >= min && userInt <= max)
                    {
                        return userInt;
                    }
                    Console.WriteLine($"Error: Please enter a number between {min} and {max}\n");

                }

                catch
                {
                    Console.WriteLine($"Error: Please enter a number between {min} and {max}\n");
                }
            }
        }
        static int CheckFood(string question, int min, int max)
        {
            Console.WriteLine(question);

            while (true)
            {
                try
                {

                    int userInt = Convert.ToInt32(Console.ReadLine());

                    if (userInt >= min && userInt <= max)
                    {
                        return userInt;
                    }
                    Console.WriteLine($"Error: Please enter a number between {min} and {max}\n");

                }

                catch
                {
                    Console.WriteLine($"Error: Please enter a number between {min} and {max}\n");
                }
            }
        }

        static string CheckName()
        {
            while (true)
            {
                // get name
                Console.WriteLine("Enter your name:\n");
                string name = Console.ReadLine();

                if (!name.Equals(""))
                {
                    // convert name to capitalized name
                    name = name[0].ToString().ToUpper() + name.Substring(1);

                    return name;
                }
                Console.WriteLine("Error: You must enter your name!");
            }
        }


        static void FarmFeeding()
        {
            // Decide which species is used

            string name = CheckName();

            Console.WriteLine($"Is your name Farmer {name}? Are you sure, Press Enter if so.");
            Console.ReadLine();

            int species = CheckSpecies("Choose a species:\n" +
               "1. Romney\n" +
               "2. KuneKune\n" +
               "3. Angus\n" +
               "4. Leghorn\n" +
               "5. Quit\n", 1, 5);

            if (species == 5)
            {
                Flag = 5;
            }

            Console.WriteLine($"You chose {species}. Are you sure to continue, press Enter.");
            Console.ReadLine();
            Console.Clear();

            int food = CheckFood("Choose your amount of food:\n" +
                "1. 300g\n" +
                "2. 2500g\n" +
                "3. 10886g\n" +
                "4. 125g\n", 1, 4);

            Console.WriteLine($"Species breed {species} eats {food} amount of food.");

        }

        static void Main()
        {
            while (Flag != 5)
            {
                FarmFeeding();
            }
        }
    }

}