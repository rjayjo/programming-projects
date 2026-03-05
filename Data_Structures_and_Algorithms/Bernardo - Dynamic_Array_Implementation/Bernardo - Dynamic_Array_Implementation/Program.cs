using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bernardo___Dynamic_Array_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            IntegerMethods numberList = new IntegerMethods();
            numberList.Add(1);
            numberList.Add(3);
            numberList.Insert(1, 5);
            numberList.Insert(2, 6);
            numberList.Insert(3, 7);
            numberList.Insert(4, 8);
            numberList.Insert(5, 9);
            numberList.Insert(6, 10);
            numberList.RemoveAt(0);
            numberList.Add(11);
            numberList.Add(12);
            numberList.Add(13);
            numberList.Insert(10, 99);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(" Array Capacity: " + numberList.ArraySize());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" Occupied Indices: " + numberList.noOfElem());
            Console.ResetColor();
            Console.WriteLine(" Elements of Array:\n");
            foreach (var item in numberList.GetArray())
            {
                Console.Write(item + "\t");
            }
            Console.ReadLine();
        }
    }
}
