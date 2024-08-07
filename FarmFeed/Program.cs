// imports
using System;
using System.Collections.Generic;

namespace FarmFeeding
{
    class Program
    {
        // Global variables
        public static List<string> species = new List<string>() { "sheep", "pig", "cow", "chicken" };
        public static List<string> Sheep = new List<string>() { "Romney","Hampshire","Dorset", "Rambouillet" };
        public static List<string> pig = new List<string>() { "Kunekune", "Hampshire", "Duroc", "Berkshire" };
        public static List<string> cow = new List<string>() { "Holstein Friedsian", "Hereford", "Simmental", "Limosusin" };
        public static List<string> chicken = new List<string>() { "Silkie", "Brahma", "Ayam", "ISA Brown" };
        public static int Flag = 0;
        public static string chosen_species = "Nothing";
        public static string chosen_breed;

        // Methods and/or function

        // Check to see if an interger enter by a user is within range
        static int CheckAnimal(string question, int min, int max)
        {
            Console.WriteLine(question);

            while (true)
            {
                try
                {
                    int userInt = Convert.ToInt32(Console.ReadLine());
                    float daily_amount = 500;

                    if (userInt >= min && userInt <= max)
                    {
                        if (chosen_species != "Nothing")
                        {
                            if (chosen_species == "Sheep")
                            {
                                chosen_breed = Sheep[userInt - 1];
                                daily_amount = 500;
                            }
                            else if (chosen_species == "Pig")
                            {
                                chosen_breed = pig[userInt - 1];
                                daily_amount = 2750;
                            }
                            else if (chosen_species == "Cow")
                            {
                                chosen_breed = cow[userInt - 1];
                                daily_amount = 10886;
                            }
                            else if (chosen_species == "Chicken")
                            {
                                chosen_breed = chicken[userInt - 1];
                                daily_amount = 125;
                            }

                            Console.Clear();
                            // repeat display for food and cost 5 times
                            for (int i = 0; i < 5; i++)
                            {
                                Random random = new Random();
                                string ID = "SBL0001#" + random.Next(01, 99);
                                float total_amount = daily_amount * 7;
                                float cost = (float)Math.Round(total_amount / 61.9, 2);
                                Console.WriteLine($"Species: {chosen_species}\nBreed: {chosen_breed}\nID: {ID}\nDay 1: {daily_amount}g\nDay 2: {daily_amount}g\nDay 3: {daily_amount}g" +
                                    $"\nDay 4: {daily_amount}g\nDay 5: {daily_amount}g\nDay 6: {daily_amount}g\nDay 7: {daily_amount}g\n\nTotal Food Consumed: {total_amount}g\nCost Per Week: ${cost}" +
                                    $"\n\nTotal Food Consumed per Year: {total_amount * 52}g\nCost Per Year: ${cost * 52}\n\n");
                                return userInt;
                                
                            }
                            

                            
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Error: Please enter a number between {min} and {max}\n");
                    }
                }
                catch
                {
                    Console.WriteLine($"Error: Please enter a number between {min} and {max}\n");
                }
                
            }
        }
        static int CheckSpecies(string question, int min, int max)
        {
            Console.WriteLine(question);

            while (true)
            {
                try
                {
                    int userInt = Convert.ToInt32(Console.ReadLine());

                    if(userInt >= min && userInt <= max)
                    {
                        if (userInt == 1)
                        {
                            chosen_species = "Sheep";
                        } 
                        else if (userInt == 2)
                        {
                            chosen_species = "Pig";
                        }
                        else if (userInt == 3)
                        {
                            chosen_species = "Cow";
                        }
                        else if (userInt == 4)
                        {
                            chosen_species = "Chicken";
                        }
                        return userInt;
                    }
                    else
                    {
                        Console.WriteLine($"Error: Please enter a number between {min} and {max}\n");
                    }
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
                    Console.Clear();
                    return name;
                }
                Console.WriteLine("Error: You must enter your name!");
            }
        }

        static void FarmFeeding()
        {
            // Write your Farmer name

            string name = CheckName();

            // Loop 5 times
            for (int i = 0; i < 5; i++)
            {

                // Decide which species is used

                int species = CheckSpecies($"Welcome {name}!\n\nChoose a species:\n" +
                   "1. Sheep\n" +
                   "2. Pig\n" +
                   "3. Cow\n" +
                   "4. Chicken\n" +
                   "5. Quit\n", 1, 5);

                if (species == 5)
                {
                    Flag = 5;
                }
                else if (species == 1)
                {
                    int sheep = CheckAnimal("Choose your breed of sheep:\n" +
                    "1. Romney\n" +
                    "2. Hampshire\n" +
                    "3. Dorset\n" +
                    "4. Rambouillet\n" +
                    "5. Quit", 1, 5);

                    if (sheep == 5)
                    {
                        Flag = 5;
                    }
                }
                else if (species == 2)
                {
                    int pig = CheckAnimal("Chooose your breed of pig:\n" +
                    "1. Kunekune\n" +
                    "2. Hampshire\n" +
                    "3. Duroc\n" +
                    "4. Berkshire\n" +
                    "5. Quit", 1, 5);

                    if (pig == 5)
                    {
                        Flag = 5;
                    }
                }
                else if (species == 3)
                {
                    int cow = CheckAnimal("Choose your breed of cow:\n" +
                    "1. Holstein Friedsian\n" +
                    "2. Hereford\n" +
                    "3. Simmental\n" +
                    "4. Limosusin\n" +
                    "5. Quit", 1, 5);

                    if (cow == 5)
                    {
                        Flag = 5;
                    }
                }
                else if (species == 4)
                {
                    int chicken = CheckAnimal("Choose your breed of chicken:\n" +
                    "1. Silkie\n" +
                    "2. Brahma\n" +
                    "3. Ayam\n" +
                    "4. ISA Brown\n" +
                    "5. Quit\n", 1, 5);

                    if (chicken == 5)
                    {
                        Flag = 5;
                    }
                }
                
            }
            
        }

        static void Main()
        {
            Console.WriteLine(@" _____ ____  ____  _        _____ _____ _____ ____  _  _      _____" + "\n" +
                              @"/    //  _ \/  __\/ \__/|  /    //  __//  __//  _ \/ \/ \  /|/  __/" + "\n" +
                              @"|  __\| / \||  \/|| |\/||  |  __\|  \  |  \  | | \|| || |\ ||| |  _" + "\n" +
                              @"| |   | |-|||    /| |  ||  | |   |  /_ |  /_ | |_/|| || | \||| |_//" + "\n" +
                              @"\_/   \_/ \|\_/\_\\_/  \|  \_/   \____\\____\\____/\_/\_/  \|\____\" + "\n");
            Console.WriteLine("____________________________________________________________________________________________________");
            Console.WriteLine("Farm Feeding is an app that is used to find the amount of money needed to feed your farm animals.\n" +
                "Select your species out of sheep, pig, cow, and chicken. After selecting your animal, select your breed.\n" +
                "After selecting your species and breed, watch the Farm Feeding app display the amount of food, and cost needed.\n");
            Console.WriteLine("____________________________________________________________________________________________________");

            Console.WriteLine("Press Enter to start.");
            Console.ReadLine();
            Console.Clear();

            while (Flag != 5)
            {
                FarmFeeding();
            }
        }
    }

}
