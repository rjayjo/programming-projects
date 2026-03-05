using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bernardo_Linear_Search_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isFound = false;
            string searchItem;
            
            string[] students = { "Arc", "Ariane", "Ponta", "Danka", "Chiyome" };
            Console.Write("Student List:\n\n");

            foreach (var item in students)
            {
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write(item + "\n");
            }

            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\n\nEnter a name to search: ");
            Console.ForegroundColor = ConsoleColor.Cyan; searchItem = Console.ReadLine();

            for (int i = 0; i < students.Length; i++)
            {
                if (searchItem == students[i])
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nThe student named \"{searchItem}\" is found at index \"{i}\"");
                    isFound = true;
                }             
            }

            if (!isFound)
            {
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"\nSorry, the student named \"{searchItem}\" is not found in the database.");
                    isFound = false;
                }
            }

            Console.ReadLine();
        }
    }
}
