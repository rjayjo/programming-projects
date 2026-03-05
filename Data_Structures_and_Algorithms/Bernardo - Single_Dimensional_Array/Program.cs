using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bernardo_Single_Dimensional_Array
{
    class Program
    {
        static void Main(string[] args)
        {           
            Console.Write("Desired range of numbers:");
            int[] numbers = new int[Convert.ToInt32(Console.ReadLine())];
       
            for (int i = 0; i < numbers.Length; i++)
            {   
                Console.Write("Enter number" + (i + 1) + ": "); numbers[i] = +
                    Convert.ToInt32(Console.ReadLine());
            }

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write("\nYou typed:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("\t" + numbers[i]);    
            }

            int lowest, highest;
            double sum = 0.0, average = 0.0;
            lowest = numbers[0];
            highest = numbers[0];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > highest)
                {
                    highest = numbers[i];
                }

                if (numbers[i] < lowest)
                {
                    lowest = numbers[i];
                }
            }

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n\nLowest Value: " + lowest);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Highest Value: " + highest);

            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
                average = sum / numbers.Length;
            }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Average: " + average);
            
            Console.ReadLine();
        }

       
       
    }
}
