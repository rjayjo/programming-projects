using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bernardo___Stack_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {

            StackArray back = new StackArray();
            StackArray forward = new StackArray();
            int input;
            Console.WriteLine("\tPerform an Operation");
            Console.WriteLine("\t[1] Add New URL");
            Console.WriteLine("\t[2] Move Backward");
            Console.WriteLine("\t[3] Move Forward");
            bool active = false;
            while (!active)
            {
                Console.Write("\n Select an Operation: "); 
                input=Convert.ToInt32(Console.ReadLine());
                if (input == 1) 
                {
                    Console.Write(" Add New URL: ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    object URL = Console.ReadLine();
                    back.Push(URL);
                    Console.ResetColor();
                }
                if (input == 2)
                {

                    Console.Write(" Moved backward. Current address is: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    forward.Push(back.Pop()); 
                    Console.Write(back.Peek()); Console.Write("\n");
                    Console.ResetColor();
                }

                if (input == 3)
                {
                    Console.Write(" Moved forward. Current address is: ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(forward.Peek()) ; Console.Write("\n");
                    forward.Pop();
                    Console.ResetColor();

                }
                
            }
        }
    }
}
