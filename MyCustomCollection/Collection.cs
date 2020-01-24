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
        public int Count;
        public int capacity = 0;

        //Constructor

        public Collection()
        {
            mainItemsArray = new T[capacity];
        }

        //Member Methods (CAN DO)

        public void Add(T item)
        {
            Count++;
            CapacityCheck();

        }
        public void CapacityCheck()
        {
            if (Count > capacity)
            {
                IncreaseTheCapacity();
                T[] transferItemsArray = CreateArray();
                TransferArrayValues();
            }
        }
        public void IncreaseTheCapacity()
        {
            if (capacity == 0)
            {
                capacity = 4;
            }
            else
            {
                int newCapacity = capacity * 2;
                capacity = newCapacity;
            }
        }
        public T[] CreateArray()
        {
           T[] dummyarray = new T[] { };
            for (int i = 0; i < capacity; i++)
            { 
                dummyarray[i] = item;
            }
            return dummyarray;
        }
        public void TransferArrayValues()
        {
            for (int i = 0; i < capacity; i++)
            {
                transferItemsArray[i] = mainItemsArray[i];
            }
            mainItemsArray = transferItemsArray;
        }
        public T this[int i]
        {
            get { return this[i]; }
            set { this[i] = value; }
        }
    }
}
