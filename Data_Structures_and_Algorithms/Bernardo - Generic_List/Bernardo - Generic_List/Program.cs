using System.Collections;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> studentRecord = new List<string>();
        Console.WriteLine("Student Records\n");
        Console.WriteLine("Perform an operation:");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("[1] ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Add a Student to the record.");

        static void Add(List<string> studentRecord)
        {
            Console.Write("Enter Student Name: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string student = Console.ReadLine();
            studentRecord.Add(student);
        }

        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("[2] ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Remove a Student from the record.");

        static void Delete(List<string> studentRecord)
        {
            Console.Write("Enter Student Name to Delete: ");
            Console.ForegroundColor = ConsoleColor.Red;
            string student = Console.ReadLine();
            studentRecord.Remove(student);
            Console.WriteLine(student + " has been deleted from the record");
        }

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("[3] ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("Edit a Student record.");

        static void Edit(List<string> studentRecord)
        {
            Console.Write("Student to Edit: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            string student = Console.ReadLine();
            studentRecord.Remove(student);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("Enter New Student Name: ");
            Console.ForegroundColor = ConsoleColor.Green;
            student = Console.ReadLine();
            studentRecord.Add(student);
            Console.WriteLine("Change Student Name to " + student + " is a success");

        }

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("[4] ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine("View all Students from the list."); 

        static void ViewAll(List<string> studentRecord)
        {
            Console.WriteLine("List of Students: ");
            foreach (var item in studentRecord)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine(item);
            }
        }

        bool ongoing = true;
        while (ongoing == true)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("\nChoose an Operation: ");
            int operation = Convert.ToInt32(Console.ReadLine());
            if (operation == 1)
            {
                Add(studentRecord);
            }
            if (operation == 2)
            {
                Delete(studentRecord);
            }
            if (operation == 3)
            {
                Edit(studentRecord);
            }
            if (operation == 4)
            {
                ViewAll(studentRecord);
            }
        }


        Console.ReadLine();
    }

}