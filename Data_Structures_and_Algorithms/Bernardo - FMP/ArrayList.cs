using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FINALS___DSTALGO__Group_1_
{
    class ArrayList
    {
        private int[] array;
        private int index;

        public ArrayList()
        {
            array = new int[5];
            index = -1;
        }

        private bool validIndex(int index)
        {
            if (index > -1 && array.Length >= index)
                return true;
            else
                throw new Exception("index out of range");
        }

        private void trackSize(int size)
        {
            if (size >= array.Length)
            {
                increaseSize();
            }
        }

        private void increaseSize()
        {
            int[] newArray = new int[array.Length * 2];
            for (int i = 0; i < array.Length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }

        public void Add(int item)
        {
            index++;
            if (index < array.Length) array[index] = item;
            else
            {
                index--;
                increaseSize();
                Add(item);
            }

        }

        public void Insert(int elemIndex, int item)
        {
            {
                trackSize(index + 1);
                validIndex(elemIndex);

                for (int i = index; i >= elemIndex; i--)
                {
                    array[i + 1] = array[i];
                }

                array[elemIndex] = item;
                index++;
            }
        }

        public void RemoveAt(int index)
        {
            trackSize(index + 1);
            if (validIndex(index))
            {
                for (int i = 0; i < this.index; i++)
                {
                    array[i] = array[i + 1];
                }
                this.index--;
            }

        }

        public void Sort()
        {
            for (int i = 1; i <= index; i++)
            {
                int itemToBeInserted = array[i];
                int j;
                for (j = i; j > 0; j--)
                {
                    if (itemToBeInserted < array[j - 1])
                    {
                        array[j] = array[j - 1];
                    }
                    else break;
                }
                array[j] = itemToBeInserted;
            }
        }

        public int BinarySearch(int item)
        {
            int lowerBound = 0;
            int upperBound = index;
            int midIndex;
            while (lowerBound <= upperBound)
            {
                midIndex = (lowerBound + upperBound) / 2;
                if (array[midIndex] == item)
                {
                    return midIndex;
                }
                else if (item < array[midIndex])
                {
                    upperBound = midIndex - 1;
                }
                else
                {
                    lowerBound = midIndex + 1;
                }
            }
            return -1;

        }

        public int[] GetArray()
        {
            int[] tempArray = new int[index + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                tempArray[i] = array[i];
            }
            return tempArray;
        }

        public int ArraySize()
        {
            return array.Length;
        }

        public int noOfElem()
        {
            return index + 1;
        }
    }
}
