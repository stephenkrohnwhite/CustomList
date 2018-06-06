using System;
using CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject3
{
    [TestClass]
    public class CustomListTest
    {
        // testMethod that tests indexer
        // testMethod that adds objects to instance of class
        // testMethod that remove objects to instance of class
        // testMethod that allows iteration
        // testMethod for overriding ToString - converts to string
        // testMethod for overloading + operator
        // testMethod for overLoading - operator
        // testMethod for count
        // testMethod for Zip
        
        [TestMethod]
        public void Add_Generic_To_Custom_List()
        {
            // arrange
            CustomList<int> num = new CustomList<int>(5);
            int expectedResult = 2;

            // act
            num.Add(expectedResult);

            // assert
            Assert.AreEqual(expectedResult, num[0]);
        }
        [TestMethod]
        public void Indexer_References_Array_Index()
        {
            // arrange
            CustomList<int> integerList = new CustomList<int>(5);
            int expectedResult = 21;

            // act
            integerList.Add(1);
            integerList.Add(21);
            int actualResult = integerList[1];

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
