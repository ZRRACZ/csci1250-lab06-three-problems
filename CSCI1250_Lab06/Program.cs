/*
* Name: Zack Racz
* Course: CSCI 1250, Section 001
* Assignment: Lab 06, Three Short Problems
* Date: October 25, 2026
* Description: A menu that keeps running until the user quits, offering three
* independent exercises or all three at once. Each exercise
* practices decisions and one of the four loops.
*/

using System.Collections.Immutable;

int choice;

do 
{
    Console.WriteLine("=== CSCI 1250 Lab06 ===");
    Console.WriteLine("1. The Grade Checker");
    Console.WriteLine("2. The Dice Table");
    Console.WriteLine("3. The Score Report");
    Console.WriteLine("4. All Three");
    Console.WriteLine("5. Quit");
    Console.WriteLine("Choose 1 through 5");

    choice = Convert.ToInt32(Console.ReadLine());

    if(choice == 1 || choice == 4)
    {
        Console.WriteLine("=== Exercise 1: The Grade Checker ===");
        Console.WriteLine("Please give me a score, 0 - 100.");
        int score = Convert.ToInt32(Console.ReadLine());

        while(score < 0 || score > 100)
        {
            Console.WriteLine("A score must be between 0 and 100.");
            score = Convert.ToInt32(Console.ReadLine());

            if(score >= 0 && score <= 59)
            {
                Console.WriteLine(score + " earns a F.");
            }
            else if(score >= 60 && score <= 69)
            {
                Console.WriteLine(score + " earns a D.");
            }
            else if(score >= 70 && score <= 79)
            {
                Console.WriteLine(score + " earns a C.");
            }
            else if(score >= 80 && score <= 89)
            {
                Console.WriteLine(score + " earns a B.");
            }
            else if(score >= 90 && score <= 100)
            {
                Console.WriteLine(score + " earns a A.");
            }
        }
    }
    if (choice == 2 || choice == 4)
    {
        Console.WriteLine("=== Exercise 2: The Dice Table ===");
        Random rng = new Random(4000);
        string answer = "Y";
        int winCount = 0;
        int rollCount = 0;

        for(int i = 1; answer.ToUpper().Equals("Y"); i++)
        {
            int die1 = rng.Next(1, 7);
            int die2 = rng.Next(1, 7);
            rollCount++;

            Console.Write("roll " + i + ": " + die1 + " and " + die2);

            if(die1 == 1 && die2 == 1)
            {
                Console.WriteLine(" Snake Eyes!");
            }
            else if(die1 == die2)
            {
                Console.WriteLine(" Doubles!");
            }
            else if(die1 + die2 == 7 || die1 + die2 == 11)
            {
                Console.WriteLine(" A Winner!");
                winCount++;
            }
            else
            {
                Console.WriteLine("");
            }

            Console.WriteLine(" Roll again?");
            answer = Console.ReadLine();
        }
        Console.WriteLine(" You rolled " + rollCount + " times and won " + winCount);
    };
    if (choice == 3 || choice == 4)
    {
        Console.WriteLine("=== Exercise 3: The Score Report ===");
        int[] scores = new int[5];

        for(int i = 0; i < 5; i++)
        {
            Console.Write(" Score " + (i + 1) + ": ");
            scores[i] = Convert.ToInt32(Console.ReadLine());
        }

        int total = 0;
        int highest = 0;
        int passing = 0;

        foreach(int score in scores)
        {
            total = score + total;
            if(score >= 60)
            {
                passing++;
            }
            if(score > highest)
            {
                highest = score;
            }
        }
        
        Console.WriteLine(" Scores entered: ");
        Console.WriteLine(" Total: " + total);
        Console.WriteLine(" Average " + Convert.ToDouble(total) / scores.Length);
        Console.WriteLine(" Highest: " + highest);
        Console.WriteLine(" Passing: " + passing + " of 5");
    }
} while(choice != 5);
Console.WriteLine("Goodbye");
