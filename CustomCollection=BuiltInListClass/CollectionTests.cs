using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomCollection_BuiltInListClass
{
    [TestClass]
    public class TestAddMethodForCollection
    {
        //[TestMethod]
        //public void AddItemsToCollection_FiveItems_Index01234()
        //{
        //    //Arange
        //    Collection<string> items = new Collection<string>();
        //    string[] value1 = { "item1", "item2", "item3", "item4", "item5" };

        //    bool actual = true;
        //    //Act
        //    items.Add(value1[0]);
        //    items.Add(value1[1]);
        //    items.Add(value1[2]);
        //    items.Add(value1[3]);
        //    items.Add(value1[4]);
        //    for (int i = 0; i < 5; i++)
        //    {
        //        if (items[i] != value1[i])
        //        {
        //            actual = false;
        //        }
        //    }

            //Assert
        //    Assert.IsTrue(actual);
        //}
        [TestMethod]
        public void AddItemToCollection_FirstItem_index0()
        {
            //Arange
            Collection<string> items = new Collection<string>();
            int expected = 0;

            //Act
            items.Add("item1");
            int actual = items[0].index;
            
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddItemToCollection_FirstItem_Count1()
        {
            //Arange
            Collection<string> items = new Collection<string>();
            int expected = 1;

            //Act
            items.Add("item1");
            int actual = items.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddItemsToCollection_FirstItem_CapacityFour()
        {
            //Arange
            Collection<string> items = new Collection<string>();
            int expected = 4;

            //Act
            items.Add("value1");
            int actual = items.capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddItemsToCollection_FiveItems_Index2()
        {
            //Arange
            Collection<string> items = new Collection<string>();
            string expected = "value3";

            //Act
            items.Add("value1");
            items.Add("value2");
            items.Add("value3");
            items.Add("value4");
            items.Add("value5");

            string actual = items[2];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddItemsToCollection_FiveItems_Index3()
        {
            //Arange
            Collection<string> items = new Collection<string>();
            string expected = "value4";
            //Act
            items.Add("value1");
            items.Add("value2");
            items.Add("value3");
            items.Add("value4");
            items.Add("value5");

            string actual = items[3];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddItemsToCollection_FiveItems_Count5()
        {
            //Arange
            Collection<string> items = new Collection<string>();
            int expected = 5;

            //Act
            items.Add("value1");
            items.Add("value2");
            items.Add("value3");
            items.Add("value4");
            items.Add("value5");
            int actual = collection.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddItemsToCollection_FiveItems_CapacityEight()
        {
            //Arange
            Collection<string> items = new Collection<string>();
            int expected = 8;

            //Act
            items.Add("value1");
            items.Add("value2");
            items.Add("value3");
            items.Add("value4");
            items.Add("value5");
            int actual = items.capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class TestRemoveMethodForCollection
    {
        [TestMethod]
        public void RemoveItemFromCollection_FirstItem_index0()
        {
            //Arange
            Collection<string> items = new Collection<string>();
            string expected = null;

            //Act
            items.Add("item1");
            items.remove("item1");
            int actual = items.index[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddItemToList_FirstItem_Count1()
        {
            //Arange
            items = new Collection<Item>();
            int expected = 1;

            //Act
            items.Add(Item item1 = new item);
            int actual = items.count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void AddItemsToList_FiveItems_Index01234()
        {
            //Arange
            items = new Collection<Item>();
            int index0 = 0;
            int index1 = 1;
            int index2 = 2;
            int index3 = 3;
            int index4 = 4;

            //Act
            items.Add(Item item1 = new Item);
            items.Add(Item item2 = new Item);
            items.Add(Item item3 = new Item);
            items.Add(Item item4 = new Item);
            items.Add(Item item5 = new Item);

            //Assert
            Assert.IsTrue((index0 == items.item1.index) || (index1 == items.item2.index) || (index2 == items.item3.index) || (index3 == items.item4.index) || (index4 == items.item5.index));
        }
        [TestMethod]
        public void AddItemsToList_FiveItems_Count5()
        {
            //Arange
            items = new Collection<Item>();
            int expected = 5;

            //Act
            items.Add(Item item1 = new Item);
            items.Add(Item item2 = new Item);
            items.Add(Item item3 = new Item);
            items.Add(Item item4 = new Item);
            items.Add(Item item5 = new Item);
            int actual = collection.count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
