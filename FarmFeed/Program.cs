// imports
using System;
using System.Collections.Generic;

namespace FarmFeeding
{
    class Program
    {
        // Global variables
        List<string> species = new List<string>() { "sheep", "pig", "cow", "chicken" };
        List<string> Sheep = new List<string>() { "Romney","Hampshire","Dorset", "Rambouillet" };
        List<string> pig = new List<string>() { "Kunekune", "Hampshire", "Duroc", "Berkshire" };
        List<string> cow = new List<string>() { "Holstein Friedsian", "Hereford", "Simmental", "Limosusin" };
        List<string> chicken = new List<string>() { "Silkie", "Brahma", "Ayam", "ISA Brown" };
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
        static int CheckSheep(string question, int min, int max)
        {
            Console.WriteLine(question);

            while (true)
            {
                try
                {
                    int userInt = Convert.ToInt32(Console.ReadLine());

                    if(userInt >= min && userInt <= max)
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
        static int CheckPig(string question, int min, int max)
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
        static int CheckCow(string question, int min, int max)
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
        static int CheckChicken(string question, int min, int max)
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
            // Write your Farmer name

            string name = CheckName();

            // Decide which species is used

            int species = CheckSpecies("Choose a species:\n" +
               "1. Sheep\n" +
               "2. Pig\n" +
               "3. Cow\n" +
               "4. Chicken\n" +
               "5. Quit\n", 1, 5);

            if (species == 5)
            {
                Flag = 5;
            }


            int sheep = CheckSheep("Choose your breed of sheep:\n" +
                "1. Romney\n" +
                "2. Hampshire\n" +
                "3. Dorset\n" +
                "4. Rambouillet\n" +
                "5. Quit", 1, 5);

            if (sheep == 5)
            {
                Flag = 5;
            }

            int pig = CheckPig("Chooose your breed of pig:\n" +
                "1. Kunekune\n" +
                "2. Hampshire\n" +
                "3. Duroc\n" +
                "4. Berkshire\n" +
                "5. Quit", 1, 5);

            if (pig == 5)
            {
                Flag = 5;
            }

            int cow = CheckCow("Choose your breed of cow:\n" +
                "1. Holstein Friedsian\n" +
                "2. Hereford\n" +
                "3. Simmental\n" +
                "4. Limosusin\n" +
                "5. Quit", 1, 5);

            if (cow == 5)
            {
                Flag = 5;
            }

            int chicken = CheckChicken("Choose your breed of chicken:\n" +
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

        static void Main()
        {
            while (Flag != 5)
            {
                FarmFeeding();
            }
        }
    }

}
