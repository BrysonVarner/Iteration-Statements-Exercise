using System;
using System.Runtime.CompilerServices;
using System.Transactions;

namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void PrintOneThousand() 
        {
            
            for (var i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
            
        }
        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void PrintByThrees() 
        {
            for (var num = 3; num < 999; num += 3)
                {
                    Console.WriteLine(num);
                }
                         
        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static bool EqualNumber(int givenNum1, int givenNum2)
        {
            if (givenNum1 == givenNum2) 
            {
                return true;
            }
            else
            {
                return false;
            }
                    
        }
        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd(int numEntered)
        {   

            if (numEntered % 2 == 0)
            {
                Console.WriteLine($"The number {numEntered} is an even number.");
            }
            else
            {
                Console.WriteLine($"The number {numEntered} is an odd number.");
            }
        }
        //Write a method to check whether a given number is positive or negative
        public static void PositiveOrNegative(int numInQuestion)
        {
            if (numInQuestion > 0)
            {
                Console.WriteLine($"Tne number {numInQuestion} is a positive number");
            }
            else if (numInQuestion < 0)
            {
                Console.WriteLine($"The number {numInQuestion} is a negative number");
            }
            else if (numInQuestion == 0)
            {
                Console.WriteLine("Silly goose! you entered a Zero!");
            }
            else
            {
                Console.WriteLine("That is not a valid number!");
            }
        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void VotingAge(string userAge)
        { 
            if (int.Parse(userAge) < 18)
            {
                var timeTillAge = 18 - int.Parse(userAge);
                Console.WriteLine($"I am sorry, you are not 18 yet. Please try back again in about {timeTillAge}!");
            }
            else
            {
                Console.WriteLine("Welcome to voter registration!");
            }
        }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void BetweenParameters(int selectedNum)
        {
            if (selectedNum <= 10 &&  selectedNum >= -10)
            {
                Console.WriteLine("This number is within range");
            }
            else 
            {
                Console.WriteLine("This number is outside the selected range");
            }
        }
        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultiplicationTable(int numToMultiply)
        {
            
            for (int i = 1; i < 13; i++)
            {
                int currentNum = numToMultiply * i;
                Console.WriteLine(currentNum);
            }
        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            PrintOneThousand();            

            PrintByThrees();

            Console.WriteLine("Are the numbers equal?");
            if (EqualNumber(3, 6))
            {
                Console.WriteLine("this is true");
            } 
            else
            {
                Console.WriteLine("this is false");
            };

            EvenOrOdd(47);

            PositiveOrNegative(6);

            Console.WriteLine("Enter your age to see if you can register to vote");
            var voterAge = Console.ReadLine();
            VotingAge(voterAge);

            BetweenParameters(-18);

            Console.WriteLine("Please enter a number for a multiplication table.");
            
            var multiplier = Console.ReadLine();
            int multNum = int.Parse(multiplier);
            MultiplicationTable(multNum);

        }
    }
}
