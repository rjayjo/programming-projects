using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALS___DSTALGO__Group_1_
{
    class CircularQueue<T>
    {
        private T[] array;
        private int count, front, rear;


        public CircularQueue()
        {
            array = new T[3];
            count = 0;
            front = 0;
            rear = -1;
        }

        public int Count
        {
            get { return count; }
        }

        public void Enqueue(T item)
        {
            if (count < array.Length)
            {
                rear = (rear + 1) % array.Length;
                array[rear] = item;
                count++;
            }
            else
            {
                IncreaseSize();
                Enqueue(item);
            }
        }

        public T Dequeue()
        {
            if (count > 0)
            {
                T item = array[front];
                front = (front + 1) % array.Length;
                count--;
                return item;
            }
            else
            {
                throw new Exception("Queue is Full");
            }
        }

        public T Peek()
        {
            if (count > 0)
            {
                T item = array[front];
                return item;
            }
            else
            {
                throw new Exception("Queue is Full");
            }
        }

        public void printQueue()
        {
            int counter = count;
            int number = 1;
            int index = front;
            while (counter > 0)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write(" " + number + ". ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(array[index]);
                index = (index + 1) % array.Length;
                Console.ForegroundColor = ConsoleColor.White;
                number++;
                counter--;
            }
        }

        private void IncreaseSize()
        {
            T[] newArray = new T[array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }

    }
}
