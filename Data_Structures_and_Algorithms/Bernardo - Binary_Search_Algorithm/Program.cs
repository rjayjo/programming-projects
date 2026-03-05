using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bernardo___Binary_Search_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int upperBound = numbers[9];
            int lowerBound = numbers[0];
            int midIndex = (upperBound + lowerBound) / 2;
            Random random = new Random();
            int randomNum = random.Next(numbers[0], numbers[9]);
            int chances = 3;
            int guess;

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(" \tRandom Guessing Game");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" The computer has generated a ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("SECRET NUMBER ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n You have");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write(" 3 CHANCES");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" to guess it, good luck :>");

            while (chances > 0)
            {
                Console.Write("\n\n Enter your guess from " + lowerBound + " to " + upperBound + ": ");
                guess = Convert.ToInt32(Console.ReadLine());
                chances--;

                if (guess == randomNum)
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" " + guess + " is indeed the SECRET NUMBER.");
                    break;

                }

                else if (guess > randomNum)
                {
                    upperBound = guess - 1;
                    Console.WriteLine(" " + guess + $" is too HIGH try a LOWER number from {lowerBound} to {upperBound}");
                }

                else
                {
                    lowerBound = guess + 1;
                    Console.WriteLine(" " + guess + $" is too LOW try a HIGHER number from {lowerBound} to {upperBound}");
                }

                if (chances == 0 && guess != randomNum)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n Sorry your CHANCES has run out");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($" The SECRET NUMBER is {randomNum}");
                }

            }

            Console.ReadLine();
        }

     }
}


        