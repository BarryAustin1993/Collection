using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCustomCollection
{
    public class Collection<T> : IEnumerable
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

        //Member Methods (CAN DO)
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
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return mainItemsArray[i];
            }
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

        //Member Remove Methods (CAN DO)
        public void Remove(T removeItem)
        {
            bool remove = compareItem(removeItem);
            if ((remove == true))
            {
                RemoveFirstVariable(removeItem);
            }
            else
            {
                throw new ArgumentOutOfRangeException("Whoops, there is no flamingo in there!");
            }
        }
        bool compareItem(T removeItem)
        {
            for (int i = 0; i < count; i++)
            {
                if (mainItemsArray[i].Equals(removeItem))
                {
                    return true;
                }
            }
            return false;
        }
        void RemoveFirstVariable(T removeItem)
        {
            int removeOnce = 0;
            for (int i = 0; i < count; i++)
            {
                if (mainItemsArray[i].Equals(removeItem) && (removeOnce < 1))
                {
                    removeOnce++;
                    transferItemsArray = CreateArray();
                    TransferRemainingValues(i);
                    count--;
                }
            }
            mainItemsArray = transferItemsArray;
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

        //Member ToString Methods (CAN DO)
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();

            for (int i = 0; i < count; i++)
            {
                stringBuilder.Append(mainItemsArray[i]);
            }
            return stringBuilder.ToString();
        }
    }
}
