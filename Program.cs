using System;
// Chase Rindlisbacher Mission 2 Assignment 1/18/23
// make a dice rolling simulation and take the percentages of each number rolled and represent them as asterisks
namespace Mission2Assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            // will need Random library for dice rolling simulation
            Random rnd = new Random();
            // start game with message
            Console.WriteLine("Welcome to the dice throwing simulator! How many dice rolls would you like to simulate?");
            // initialize necessary variables and arrays, also grab user input for how many times to roll and convert to int.
            string numRolls = Console.ReadLine();
            int iNumRolls = Convert.ToInt32(numRolls);
            int[] rollTotals = new int[11];
            decimal[] percRolled = new decimal[11];
            string[] percentsOfRolls = new string[11];

            //Simulate the roll of the dice
            for (int i = 0; i < iNumRolls; i++)
            {
                int roll1 = rnd.Next(6) + 1;
                int roll2 = rnd.Next(6) + 1;
                int rollSum = roll1 + roll2;
                rollTotals[(rollSum - 2)]++;
            }
            // post message above results that will be calculated below
            Console.WriteLine("DICE ROLLING SIMULATION RESULTS\nEach \"*\" represents 1 % of the total number of rolls.");
            Console.WriteLine("Total number of rolls equals " + iNumRolls + ".");
            // calculate percentages of total rolls to determine number of asterisks to print and prints them
            for (int i = 0; i < 11; i++)
            {
                decimal decRollTotals = rollTotals[i];
                percRolled[i] = decRollTotals * 100 / iNumRolls;
                decimal numPercent = percRolled[i];
                string starSpangledString = "";
                // Make a string full of asterisks
                while ((numPercent - 1) >= 0)
                {
                    starSpangledString = starSpangledString + '*';
                    numPercent--;
                }
                percentsOfRolls[i] = starSpangledString;
                Console.WriteLine((i + 2) + ": " + percentsOfRolls[i]);
            }
        }
    } // end class
}
