using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FINALS___DSTALGO__Group_1_
{
    class Program
    {
        static void Main(string[] args)
        {

            StackArray<object> MenuTop = new StackArray<object>();
            StackArray<object> MenuBot = new StackArray<object>();
            CircularQueue<string> simple = new CircularQueue<string>();
            CircularQueue<string> date = new CircularQueue<string>();
            CircularQueue<string> family = new CircularQueue<string>();
            CircularQueue<string> customers = new CircularQueue<string>();
            ArrayList SimpleTable = new ArrayList();
            //var simplelist = SimpleTable.Cast<int>().ToList();
            ArrayList DateTable = new ArrayList();
            //var datelist = DateTable.Cast<int>().ToList();
            ArrayList FamilyTable = new ArrayList();
            //var familylist = FamilyTable.Cast<int>().ToList();
            Dictionary<int, string> Table = new Dictionary<int, string>();
            Console.WriteLine("[=====================================]");
            Console.Write(" ||  RESTAURANT RESERVATION SYSTEM  ||\n");
            Console.Write(" ||\t                            ||\n ||  [1] - Customer View            ||\t\n ||  [2] - Admin View              " +
                " ||\n ||                                 ||\n" +
                " <===================================>");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("\t\n\tEnter Your choice: ");
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.Black;
            int chooseView = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();

            if (chooseView == 1)
            {
                CustomerView();
            }
            if (chooseView == 2)
            {
                AdminView();
            }
            

            // Menu Stack
            MenuBot.Push(" ==> KOREAN BEEF OPTIONS\n \f Beef Samgyup\n \f Yangnyum Beef\n \f Boolgogi\n \f Gochujang Beef\n \f Sarsa Beef");
            MenuBot.Push(" ==> KOREAN PORK OPTIONS\n \f Dae-Pae\n \f Bul-Jib\n \f Yangnyum Daepae\n \f Gochujang Samgyup\n \f Yangnyum Buljib");
            MenuBot.Push(" ==> VEGETARIAN OPTIONS\n \f Veggie Burger\n \f Roasted Mix Veg\n \f Vegetarian Nut Roast\n \f Vegan Pizza\n \f Spinach Lasagne\n \f Veggie Curry\n \f Black Bean Bake\n \f Lentil Stew");

            // Table List
            SimpleTable.Add(1); 
            SimpleTable.Add(2);
            SimpleTable.Add(3);
            FamilyTable.Add(7);
            FamilyTable.Add(8);
            FamilyTable.Add(9);
            DateTable.Add(4);
            DateTable.Add(5);
            DateTable.Add(6);

            int tables;
            int TableNumber;
            string Customername;
            string details ;
            int response;

            do
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("\n\tEnter Your Choice: ");
                Console.BackgroundColor = ConsoleColor.DarkGreen;
                Console.ForegroundColor = ConsoleColor.Black;
                tables = int.Parse(Console.ReadLine());
                Console.ResetColor();
                switch (tables)
                {
                    case 1:
                        Console.WriteLine("\n"+MenuBot.Peek());
                        Console.Write("\n Type [1] to navigate FORWARD [2] to navigate BACKWARD: ");
                        response = Convert.ToInt32(Console.ReadLine());
                        if (response == 1)
                        {
                            MenuTop.Push(MenuBot.Pop());
                            Console.Write(MenuBot.Peek()); Console.Write("\n");    
                        }
                        if (response == 2)
                        {
                            Console.Write(MenuTop.Peek()); Console.Write("\n");
                            MenuTop.Pop();
                        }
                        break;
                    case 2:
                        Console.ForegroundColor = ConsoleColor.Green; Console.Write("\n [+] ");
                        Console.ResetColor(); Console.Write("CREATE CUSTOMER IDENTITY");
                        Console.Write("\t\n Ex: (Food Option) - (Name)\n       Vegetarian  - Cardo Dalisay\n");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("\n Enter Customer Name: ");
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.ForegroundColor = ConsoleColor.White;
                        details = Console.ReadLine();
                        Console.ResetColor();
                        Console.Write(" Customer and Food Option has been added to Queue. \n\nPress <Enter> to continue...");
                        Console.ReadLine();
                        customers.Enqueue(details);
                        break;
                    case 3:
                        Console.ForegroundColor = ConsoleColor.Magenta; Console.Write("\n\t<#> ");
                        Console.ResetColor(); Console.Write("TABLE SET-UP\n");
                        Console.Write(" \t[1] - SIMPLE Table Good for (1 Person)\n\t[2] - DATE Table Good for (2 Persons)\n\t[3] - FAMILY Table Good for (3 - 8 persons)\n");
                        Console.Write("\n \t Enter Your Choice: ");
                        response = Convert.ToInt32(Console.ReadLine());
                        if (response == 1)
                        {
                            simple.Enqueue(customers.Peek());
                            Console.Write(" Customer Booking Request [" + customers.Dequeue() + "] @ Simple Table");
                            Console.Write("\n\n Press <Enter> to continue...");
                            details = Console.ReadLine();
                        }
                        if (response == 2)
                        {
                            date.Enqueue(customers.Peek());
                            Console.Write(" Customer Booking Request [" + customers.Dequeue() + "] @ Date Table");
                            Console.Write("\n\n Press <Enter> to continue...");
                            details = Console.ReadLine();
                        }
                        if (response == 3)
                        {
                            family.Enqueue(customers.Peek());
                            Console.Write(" Customer Booking Request [" + customers.Dequeue() + "] @ Family Table");
                            Console.Write("\n\n Press <Enter> to continue...");
                            details = Console.ReadLine();
                        }
                        break;
                    case 4:
                        if (Table.Count > 0)
                        {

                            foreach (var detail in Table)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine(" Table Number\t" + detail.Key + " : " + detail.Value);
                                Console.ForegroundColor = ConsoleColor.White;

                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\t\n There are no confirmed RESERVATIONS yet...");
                            Console.ResetColor();
                        }
                        Console.Write("\n Press <enter> to go back to main menu..");
                        Console.ReadLine();
                        break;
                    case 5:
                        Console.Clear();
                        AdminView();
                        break;
                    case 6:
                        Console.WriteLine("~~ Customers Request Reservation at Simple Table ~~");
                        simple.printQueue();
                        Console.WriteLine("~~ Customers Request Reservation at Date Table ~~");
                        date.printQueue();
                        Console.WriteLine("~~ Customers Request Reservation at Family Table ~~");
                        family.printQueue();
                        Console.WriteLine("~~ Remaining Request on Queue ~~");
                        customers.printQueue();
                        break;
                    case 7:
                        
                        foreach (var item in SimpleTable.GetArray())
                        {
                            Console.Write(" Simple Table Number: " + item + "\t" + "\n");
                        }
                    
                        foreach (var item in DateTable.GetArray())
                        {
                            Console.Write("\n");
                            Console.Write(" Date Table Number: " + item + "\t");
                        }
                        
                        Console.Write("\n");
                        foreach (var item in FamilyTable.GetArray())
                        {
                            Console.Write("\n");
                            Console.Write(" Family Table Number: " + item + "\t");
                        }
                        Console.Write("\n\n Enter Table Number: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        TableNumber = int.Parse(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(" Enter Food Bundle & Customer Name: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Customername = Console.ReadLine();
                        Console.ForegroundColor = ConsoleColor.White;
                        if (Table.TryAdd(TableNumber, Customername))
                        {
                            Table.TryAdd(TableNumber, Customername);
                            Console.WriteLine(" Table Reservation Success!");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" Table is already Taken!");
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\n Press <enter> to go back to main menu..");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                        break;
                    case 8:
                        Console.Write(" Enter Table Number: ");
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        TableNumber = Convert.ToInt32(Console.ReadLine());

                        Console.ForegroundColor = ConsoleColor.White;
                        if (Table.ContainsKey(TableNumber))
                        {
                            foreach (var detail in Table)
                            {
                                if (detail.Key == TableNumber)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write("\n\t Table is reserved to: " + detail.Key + "-" + detail.Value + "\n");
                                }
                                
                            }
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" Record Not Found\n");
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\n Press <enter> to go back to main menu..");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                        break;
                    case 9:
                        Console.Write(" Enter Table Number: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        TableNumber = int.Parse(Console.ReadLine());
                        if (Table.ContainsKey(TableNumber))
                        {
                            Console.Write(" Enter new Food Bundle & Customer Name: ");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Customername = Console.ReadLine();
                            Table[TableNumber] = Customername;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(" Table "+ TableNumber + " has been update with new Customer Name " + Customername);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" No Record Found\n");
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\n Press <enter> to go back to main menu..");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                        break;
                    case 10:
                        Console.Write(" Delete Table Number: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        TableNumber = int.Parse(Console.ReadLine());
                        Console.ForegroundColor = ConsoleColor.White;
                        if (Table.ContainsKey(TableNumber))
                        {
                            details = Table[TableNumber];
                            Table.Remove(TableNumber);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine(TableNumber + " - " + details + " has been deleted!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write(" No Record Found\n");
                        }
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("\n Press <enter> to go back to main menu..");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.ReadLine();
                        break;
                    case 11:
                        Console.Clear();
                        CustomerView();
                        break;
                }
            }
            while (tables != 12);
            {
                Console.Write("The End");
            }

            static void CustomerView()
            {
                Console.Write("\n\t |~ CUSTOMER OPTIONS ~|\n\n\t[1] - View Restaurant Menu (Food Options)\n\t[2] - Create User and Set Desired Food Option\n\t[3] - Table Request (Type of Table Set-up) \n\t[4] - Display List of Confirmed Reservations \n\t[5] - Admin View\n\t[12] - End Program\n\n");
            }
            static void AdminView()
            {
                Console.Write("\n\t |~ ADMIN CONTROLLERS ~|\n\n\t[6] - View Queue of Requested Reservation \n\t[7] - Add Reservation \n\t[8] - Search Reservation (Table Availability)\n\t[9] - Update Reservation\n\t[10] - Delete Reservation\n\t[11] - Customer View\n\t[12] - End Program\n\n");
            }
        }
    }
}
