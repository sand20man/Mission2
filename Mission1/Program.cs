﻿// See https://aka.ms/new-console-template for more information

namespace Mission1;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate?");
        
        int numberOfRolls = int.Parse(Console.ReadLine()!); //User input of desired rolls
        Rolling.Roll(numberOfRolls); //Rolling Dice

        
        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {numberOfRolls}");
        
        for (int i = 1; i < Rolling.RollNum.Length; i++) // Calculating results
        {
            int percentage = (int)((double)Rolling.RollNum[i] / numberOfRolls * 100);
            Console.WriteLine($"{i + 1}: {new string('*', percentage)} ({percentage}%)"); // Turning int into *
        }
        
        Console.WriteLine("Thank you for using the dice throwing simulator.  Goodbye!");
    }
}