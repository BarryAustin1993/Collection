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
            int actual = items.Capacity;

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
            int actual = items.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
    [TestClass]
    public class TestRemoveMethodForCollection
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveItemFromCollection_FirstItem_index0()
        {
            //Arange
            Collection<string> items = new Collection<string>();

            //Act
            items.Add("value1");
            items.Remove("value1");
            string actual = items[0];

            //Assert
        }
        [TestMethod]
        public void RemoveItemFromCollection_FirstItem_Count0()
        {
            //Arange
            Collection<string> items = new Collection<string>();
            int expected = 0;

            //Act
            items.Add("value1");
            items.Remove("value1");
            int actual = items.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveItemFromCollection_FirstItem_Capacity4()
        {
            //Arange
            Collection<string> items = new Collection<string>();
            int expected = 4;

            //Act
            items.Add("value1");
            items.Remove("value1");
            int actual = items.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveItemFromCollection_FiveItems_Index0()
        {
            //Arange
            Collection<string> items = new Collection<string>();
            string expected = "value2";

            //Act
            items.Add("value1");
            items.Add("value2");
            items.Add("value3");
            items.Add("value4");
            items.Add("value5");
            items.Remove("value1");

            string actual = items[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveItemFromCollection_FiveItems_Index2()
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
            items.Remove("value1");

            string actual = items[2];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveItemFromCollection_FiveItems_Index3()
        {
            //Arange
            Collection<string> items = new Collection<string>();
            string expected = "value5";

            //Act
            items.Add("value1");
            items.Add("value2");
            items.Add("value3");
            items.Add("value4");
            items.Add("value5");
            items.Remove("value1");

            string actual = items[3];
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveItemFromCollection_FiveItems_Count4()
        {
            //Arange
            Collection<string> items = new Collection<string>();
            int expected = 4;

            //Act
            items.Add("value1");
            items.Add("value2");
            items.Add("value3");
            items.Add("value4");
            items.Add("value5");
            items.Remove("value1");

            int actual = items.Count;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveItemFromCollection_FiveItems_Capacity8()
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
            items.Add("value6");
            items.Remove("value1");

            int actual = items.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void RemoveItemFromCollection_DoesNotExist_index0()
        {
            //Arange
            Collection<string> items = new Collection<string>();

            //Act
            items.Remove("value1");
            string actual = items[0];

            //Assert
        }
        [TestMethod]
        public void RemoveMultipleItemsFromCollection_7Items_index3()
        {
            //Arange
            Collection<string> items = new Collection<string>();
            string expected = "value6";

            //Act
            items.Add("value1");
            items.Add("value2");
            items.Add("value3");
            items.Add("value4");
            items.Add("value5");
            items.Add("value6");
            items.Add("value7");
            items.Remove("value1");
            items.Remove("value3");
            string actual = items[3];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveItemWithTwinInCollection_7Items_index3()
        {
            //Arange
            Collection<string> items = new Collection<string>();
            string expected = "value2";

            //Act
            items.Add("value1");
            items.Add("value2");
            items.Add("value3");
            items.Add("value4");
            items.Add("value5");
            items.Add("value6");
            items.Add("value2");
            items.Remove("value2");
            string actual = items[5];

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void RemoveItemBeforeAddingMore_7Items_index()
        {
            //Arange
            Collection<string> items = new Collection<string>();
            string expected = "value6";

            //Act
            items.Add("value1");
            items.Add("value2");
            items.Remove("value2");
            items.Add("value3");
            items.Add("value4");
            items.Add("value5");
            items.Add("value6");

            string actual = items[4];

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
    [TestClass]
    public class TestToStringsMethodForCollection
    {
        [TestMethod]
        public void ConvertIntCollectionToString_SevenInts_OneStrings()
        {
            //Arange
            Collection<int> collection = new Collection<int>() { 1, 2, 3, 4, 5, 6, 7, 8};
            string expected = "12345678";

            //Act
            
            string actual = collection.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ConvertIntCollectionToString_PartialCapactiy_OneStrings()
        {
            //Arange
            Collection<int> collection = new Collection<int>() {1, 2, 3};
            string expected = "123";

            //Act

            string actual = collection.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ConvertstringsCollectionToString_FourStrings_OneString()
        {
            //Arange
            Collection<string> collection = new Collection<string>() { "there", "is", "no", "flamingo"};
            string expected = "thereisnoflamingo";

            //Act

            string actual = collection.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

    }
    [TestClass]
    public class TestOverloadingPlusOperatorForCollection
    {
        [TestMethod]
        public void CombineTwoCollections_One135Two246__Three135246()
        {
            //Arange
            Collection<string> collection1 = new Collection<string>() { "1", "3", "5" };
            Collection<string> collection2 = new Collection<string>() { "2", "4", "6" };
            string expected = "135246";

            //Act
            Collection<string> actual = collection1 + collection2;
            string actually = actual.ToString();

            //Assert
            Assert.AreEqual(expected, actually);
        }
        [TestMethod]
        public void CombineTwoCollections_One1357Two246__Three1357246()
        {
            //Arange
            Collection<string> collection1 = new Collection<string>() { "1", "3", "5", "7" };
            Collection<string> collection2 = new Collection<string>() { "2", "4", "6" };
            string expected = "1357246";

            //Act
            Collection<string> actual = collection1 + collection2;
            string actually = actual.ToString();

            //Assert
            Assert.AreEqual(expected, actually);
        }
        [TestMethod]
        public void CombineTwoCollectionsInt_One1357Two246__Three1357246()
        {
            //Arange
            Collection<int> collection1 = new Collection<int>() { 1, 3, 5, 7 };
            Collection<int> collection2 = new Collection<int>() { 2, 4, 6, 8, 10 };
            string expected = "1357246810";

            //Act
            
            Collection<int> actual = collection1 + collection2;
            string actually = actual.ToString();
            //Assert
            Assert.AreEqual(expected, actually);
        }
        [TestMethod]
        public void CombineTwoCollections_CountThreeAndThree__CountSix()
        {
            //Arange
            Collection<string> collection1 = new Collection<string>() { "1", "3", "5" };
            Collection<string> collection2 = new Collection<string>() { "2", "4", "6" };
            int expected = 6;

            //Act

            Collection<string> collection3 = collection1 + collection2;
            int actual = collection3.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CombineTwoCollections_CapacityThreeAndThree__CapacaityEight()
        {
            //Arange
            Collection<string> collection1 = new Collection<string>() { "1", "3", "5" };
            Collection<string> collection2 = new Collection<string>() { "2", "4", "6" };
            int expected = 8;

            //Act

            Collection<string> collection3 = collection1 + collection2;
            int actual = collection3.Capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CombineTwoCollections_OneEmptyList__WhatHappens()
        {
            //Arange
            Collection<string> collection1 = new Collection<string>() { "1", "3", "5" };
            Collection<string> collection2 = new Collection<string>() { };
            string expected = "135";

            //Act
            Collection<string> actual = collection1 + collection2;
            string actually = actual.ToString();
            //Assert
            Assert.AreEqual(expected, actually);
        }
    }
}
