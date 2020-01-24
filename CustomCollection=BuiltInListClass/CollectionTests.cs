using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyCustomCollection;

namespace CustomCollection_BuiltInListClass
{
    [TestClass]
    public class TestAddMethodForCollection
    {
        //[TestMethod]
        //public void AddItemsToCollection_FiveItems_Index01234()
        //{
            //Arange
        //    Collection<string> items = new Collection<string>();
        //    string[] value1 = { "item1", "item2", "item3", "item4", "item5" };

        //    bool actual = true;
        //    //Act
        //    items.Add(value1[0 ++]);
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

        //    Assert
        //    Assert.IsTrue(actual);
        //}
        [TestMethod]
        public void AddItemToCollection_FirstItem_index0()
        {
            //Arange
            Collection<string> items = new Collection<string>();
            string expected = "value1";

            //Act
            items.Add("value1");

            string actual = items[0];
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
            int actual = items.Count;

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

    }
}
