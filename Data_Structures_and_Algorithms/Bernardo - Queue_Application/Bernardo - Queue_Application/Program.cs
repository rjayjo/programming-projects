using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bernardo___Queue_Application
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularQueue<string> mainQueue = new CircularQueue<string>();  
            CircularQueue<string> counterA = new CircularQueue<string>();
            CircularQueue<string> counterB = new CircularQueue<string>();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\tBank Transaction Queueing System");
            Console.ResetColor();
            Console.WriteLine("\t[1] - New Customer");
            Console.WriteLine("\t[2] - View All Customer");
            Console.Write("\t[3] - Serve Next Customer");
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(" @ Counter A");
            Console.ResetColor(); Console.Write("\t[4] - Serve Next Customer");
            Console.ForegroundColor = ConsoleColor.Blue; Console.WriteLine(" @ Counter B");
            Console.ResetColor();
            Console.WriteLine("\t[5] - View Customer Queueing Summary");
            Console.WriteLine("\t[x] - Exit");
            bool session = true;
            while (session)
            {
                Console.Write("\n Select an Action: ");
                string option = Console.ReadLine();
                if ("x" == option)
                {
                    session = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" You have succesfully terminated the session. " +
                        "\n You may now close the app.");
                    return;
                }
                if (Convert.ToInt32(option) == 1)
                {
                    Console.Write(" Enter Customer Name: ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    string customerName = Console.ReadLine();
                    mainQueue.Enqueue(customerName);
                    Console.WriteLine($" Customer [" + customerName + "] has been added to the Queue.") ;
                    Console.ResetColor();
                }
                if (Convert.ToInt32(option) == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" Queue of Unattended Customers:");
                    mainQueue.printQueue();
                    Console.ResetColor();
                   
                }
                if (Convert.ToInt32(option) == 3)
                {
                    counterA.Enqueue(mainQueue.Dequeue());
                    Console.WriteLine(" Currently Serving Customer [" + counterA.Peek() + "] in Counter A");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" Queue in Counter A:");
                    counterA.printQueue();
                    Console.ResetColor();

                }
                if (Convert.ToInt32(option) == 4)
                {
                    counterB.Enqueue(mainQueue.Dequeue());
                    Console.WriteLine(" Currently Serving Customer [" + counterB.Peek() + "] in Counter B");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(" Queue in Counter B:");
                    counterB.printQueue();
                    Console.ResetColor();
                }
                if (Convert.ToInt32(option) == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Green; 
                    Console.WriteLine(" Customers queued at Counter A");
                    counterA.printQueue();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(" Customers queued at Counter B");
                    counterB.printQueue();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" Customers that are still unattended");
                    mainQueue.printQueue();
                    Console.ResetColor();
                }
               
            }
        }
    }
}
