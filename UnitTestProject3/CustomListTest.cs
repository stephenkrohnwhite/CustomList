using System;
using CustomList;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject3
{
    [TestClass]
    public class CustomListTest
    {
        
        // testMethod for overloading + operator
        // testMethod for overLoading - operator
        // testMethod for count
        // testMethod for Zip
        
        [TestMethod]
        public void Add_Generic_To_CustomList_Expect_Generic_In_CustomList()
        {
            // arrange
            CustomList<int> num = new CustomList<int>();
            int expectedResult = 2;

            // act
            num.Add(expectedResult);

            // assert
            Assert.AreEqual(expectedResult, num[0]);
        }
        [TestMethod]
        public void Count_Property_Equals_NotNull_Generics()
        {
            // arrange
            CustomList<int> integerList = new CustomList<int>();
            int expectedResult = 2;

            // act
            integerList.Add(1);
            integerList.Add(4);
            int actualResult = integerList.Count;

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Capacity_Adds_Expected_Value()
        {
            // arrange
            CustomList<int> integerList = new CustomList<int>();
            int expectedResult = 10;

            // act
            integerList.Add(1);
            integerList.Add(4);
            integerList.Add(1);
            integerList.Add(4);
            int actualResult = integerList.Capacity;

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Indexer_References_Array_Index()
        {
            // arrange
            CustomList<int> integerList = new CustomList<int>();
            int expectedResult = 21;

            // act
            integerList.Add(1);
            integerList.Add(21);
            int actualResult = integerList[1];

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Remove_Generic_From_CustomList_Expect_Generic_Removed_From_CustomList()
        {
            // arrange
            CustomList<int> integerList = new CustomList<int>();
            int expectedResult = 2;

            // act
            integerList.Add(1);
            integerList.Add(2);
            integerList.Remove(1);
            int actualResult = integerList[0];

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Remove_Object_Returns_False_When_Argument_Finds_No_Match()
        {
            // arrange
            CustomList<int> integerList = new CustomList<int>();
            bool expectedResult = false;

            // act
            integerList.Add(1);
            integerList.Add(2);
            bool actualResult = integerList.Remove(7);
           
            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void Remove_object_Reduces_Count()
        {
            // arrange
            CustomList<int> integerList = new CustomList<int>();
            int expectedResult = 1;

            // act
            integerList.Add(1);
            integerList.Add(102);
            integerList.Add(7);
            integerList.Remove(7);
            integerList.Remove(1);
            int actualResult = integerList.Count;

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ToString_Method_Returns_CustomList_As_String()
        {
            // arrange
            CustomList<int> List = new CustomList<int>();
            string expectedResult = "1, 2";

            // act
            List.Add(1);
            List.Add(2);
            string actualResult = List.ToString();

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }
        [TestMethod]
        public void ToString_Method_Returns_Expected_CharLength()
        {
            // arrange
            CustomList<int> List = new CustomList<int>();
            int expectedResult = 4;

            // act
            List.Add(1);
            List.Add(7);
            string stringList = List.ToString();
            int actualResult = stringList.Length;

            // assert
            Assert.AreEqual(expectedResult, actualResult);
        }
       
    }
}
