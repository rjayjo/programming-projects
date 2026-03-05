using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALS___DSTALGO__Group_1_
{
    class StackArray<T>
    {
        private T[] array;
        private int top;

        public StackArray()
        {
            array = new T[5];
            top = -1;

        }

        public void Push(T item)
        {
            if (top < array.Length - 1)
            {
                top++;
                array[top] = item;
            }
            else
            {
                IncreaseSize();
                Push(item);
            }
        }

        public object Pop()
        {
            if (top > -1)
            {

                T item = array[top];
                top--;
                return item;
            }
            else Console.Write("Unable to move backward!");
            throw new Exception("Stack Underflow!");
        }

        public object Peek()
        {
            if (top > -1)
            {
                T item = array[top];
                return item;
            }
            else Console.Write("Unable to proceed forward!");
            throw new Exception("Stack Overflow");
        }

        public void Clear()
        {
            top = -1;
        }

        public void PrintStack()
        {
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(array[i]);

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
