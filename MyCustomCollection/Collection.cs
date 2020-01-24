﻿using System;
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
        public int capacity;
        int index = 0;

        //Constructor

        public Collection()
        {
            mainItemsArray = new T[capacity];
        }

        //Member Methods (CAN DO)

        public void Add(T item)
        {
            
            CapacityCheck();
            Count++;
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
            get { return mainItemsArray[i]; }
            set { mainItemsArray[i] = value; }
        }
    }
}
