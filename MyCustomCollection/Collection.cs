using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomCollection
{
    public class Collection<T>
    {
        //Member Variables (HAS A)

        T[] mainItemsArray;
        T[] transferItemsArray;
        T item;
        int count;
        public int Count
        {
            get
            {
                return count;
            }
        }
        int capacity;
        public int Capacity
        {
            get
            {
                return capacity;
            }
        }
        int index = 0;

        //Constructor

        public Collection()
        {
            mainItemsArray = new T[capacity];
        }

        //Member Add Methods (CAN DO)

        public void Add(T item)
        {

            CapacityCheck();
            count++;
            AddItemToIndex(item);
        }
        void CapacityCheck()
        {
            if (Count == capacity)
            {
                IncreaseTheCapacity();
                transferItemsArray = CreateArray();
                TransferArrayValues();
            }
        }
        void IncreaseTheCapacity()
        {
            if (capacity == 0)
            {
                capacity = 4;
                mainItemsArray = CreateArray();
            }
            else
            {
                int newCapacity = capacity * 2;
                capacity = newCapacity;
            }
        }
        T[] CreateArray()
        {
            T[] spaceHoldArray = new T[capacity];
            for (int i = 0; i < capacity; i++)
            {
                spaceHoldArray[i] = item;
            }
            return spaceHoldArray;
        }
        void TransferArrayValues()
        {
            for (int i = 0; i < Count; i++)
            {
                transferItemsArray[i] = mainItemsArray[i];
            }
            mainItemsArray = transferItemsArray;
        }
        void AddItemToIndex(T item)
        {
            mainItemsArray[index] = item;
            index++;
        }
        public T this[int i]
        {
            get
            {
                if (i < Count)
                {
                    return mainItemsArray[i];
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Whoops, try again!");
                }
            }
            set
            { 
                mainItemsArray[i] = value; 
            }
        }

        //Member Remove Methods (CAN DO)
        public void Remove(T removeItem)
        {
            compareItem(removeItem);
        }
        void compareItem(T removeItem)
        {
            int singletime = 0;
            for (int i = 0; i < count; i++)
            {
                if (mainItemsArray[i].Equals(removeItem) && singletime < 1)
                {
                    transferItemsArray = CreateArray();
                    TransferRemainingValues(i);
                    count--;
                    mainItemsArray = transferItemsArray;
                    singletime = 1;
                }
                else if (singletime == 1)
                {
                    break;
                }
                else
                {
                    //throw new ArgumentOutOfRangeException("Whoops, there is no Flamingo here!");
                }
            }
        }
        void TransferRemainingValues(int i)
        {
            int k = 0;
            for (int j = 0; j < count; j++)
            {
                if (j == i)
                {
                    k++;
                    j--;
                    i = -1;
                }
                else if (k == count)
                {
                    index--;
                    break;
                }
                else
                {
                    transferItemsArray[j] = mainItemsArray[k];
                    k++;
                }

            }
        }
    }
}
