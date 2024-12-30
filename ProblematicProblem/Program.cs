using System;
using System.Collections.Generic;
using System.Threading;

namespace ProblematicProblem
{
    class Program
    {
        static Random rng = new Random();
        static bool cont = true;
    
        static List<string> activities = new List<string>()
        {"Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting"};
        static void Main(string[] args)
        {
            Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");
            var userInput = Console.ReadLine().ToLower();

            while (userInput != "yes" && userInput != "no")
            {
                Console.WriteLine("Invalid response. Please enter yes or no.");
                userInput = Console.ReadLine().ToLower();
            }

            if (userInput == "no")
            {
                Console.WriteLine("Goodby!");
                return;
            }
            
            Console.WriteLine();
            Console.Write("We are going to need your information first! What is your name? ");
            string userName = Console.ReadLine();
            
            Console.WriteLine();
            Console.Write("What is your age? ");
            int userAge;
            while (!int.TryParse(Console.ReadLine(), out userAge))
            {
                Console.Write("Invalid response. Please enter a number: ");
            }
            
            Console.WriteLine();
            Console.Write("Would you like to see the current list of activities? Sure/No thanks: ");
            userInput = Console.ReadLine().ToLower();
            while (userInput != "sure" && userInput != "no thanks")
            {
                Console.Write("Invalid response. Please enter Sure or No Thanks:");
                userInput = Console.ReadLine().ToLower();
            }

            if (userInput == "sure")
            {   
                foreach (string activity in activities)
                {
                Console.Write($"{activity} ");
                Thread.Sleep(250);
                }
        
            Console.WriteLine();
            Console.Write("Would you like to add any activities before we generate one? yes/no: ");
            userInput = Console.ReadLine().ToLower();
            while (userInput != "yes" && userInput != "no")
                {
                    Console.Write("Invalid response. Please enter yes or no:");
                    userInput = Console.ReadLine().ToLower();
                }
       
            while (userInput == "yes")
            {
                Console.Write("What would you like to add? ");
                string userAddition = Console.ReadLine();
                activities.Add(userAddition);
                foreach (string activity in activities)
                {
                    Console.Write($"{activity} ");
                    Thread.Sleep(250);
                }
                Console.WriteLine();
                Console.WriteLine("Would you like to add more? yes/no: ");
                userInput = Console.ReadLine().ToLower();
                while (userInput != "yes" && userInput != "no")
                    {
                        Console.Write("Invalid response. Please enter yes or no:");
                        userInput = Console.ReadLine().ToLower();
                    }
                }
    }

        while (cont)
        {
            Console.Write("Connecting to the database");
            for (int i = 0; i < 10; i++)
        {
            Console.Write(". ");
            Thread.Sleep(500);
        }
        
        Console.WriteLine();
        Console.Write("Choosing your random activity");
        for (int i = 0; i < 9; i++)
        {
            Console.Write(". ");
            Thread.Sleep(500);
        }
        
        Console.WriteLine();
        int randomNumber = rng.Next(activities.Count);
        string randomActivity = activities[randomNumber];
        if (userAge < 21 && randomActivity == "Wine Tasting")
        {
            Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
            Console.WriteLine("Pick something else!");
            activities.Remove(randomActivity);
            randomNumber = rng.Next(activities.Count);
            randomActivity = activities[randomNumber];
        }
        
        Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to grab another activity? Keep/Redo: ");
        Console.WriteLine();
        userInput = Console.ReadLine().ToLower();
        while (userInput != "keep" && userInput != "redo")
        {
            Console.Write("Invalid response. Please enter Keep or Redo:");
            userInput = Console.ReadLine().ToLower();
        }
                if (userInput == "keep")
                {
                    cont = false;
                }
        }
        }
    }
}