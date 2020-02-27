using System;
using System.Collections.Generic;
using CustomListProject;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        //UnitOfWork_SateUnderTest_ExpectedBehavior
        public void CreatedList_AddToList_ValuesCombined()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            string firstValue = "4";
            int expected = 2;

            //act
            customList.Add(firstValue);
            customList.Add(firstValue);
            //assert
            Assert.AreEqual(expected, customList.count);
        }
        [TestMethod]
        public void CreatedList_AddToList_CheckIndex()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            string firstValue = "4";
            string expected = "4";

            //act
            customList.Add(firstValue);
            customList.Add(firstValue);
            //assert
            Assert.AreEqual(expected, customList[1]);

        }
        [TestMethod]
        public void CreatedList_AddToList_CheckIndexIncrease()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            string firstValue = "4";
            string secondValue = "pie";
            string thirdValue = "star";
            string fourthValue = "light";
            string fifthValue = "ham";
            int expected = 5;

            //act
            customList.Add(firstValue);
            customList.Add(secondValue);
            customList.Add(thirdValue);
            customList.Add(fourthValue);
            customList.Add(fifthValue);
            //assert
            Assert.AreEqual(expected, customList.count);

        }
        [TestMethod]
        public void CreatedList_AddToList_CheckIndexCap4()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            string firstValue = "4";
            string secondValue = "pie";
            string thirdValue = "star";
            int expected = 4;

            //act
            customList.Add(firstValue);
            customList.Add(secondValue);
            customList.Add(thirdValue);

            //assert
            Assert.AreEqual(expected, customList.capacity);

        }
        [TestMethod]
        public void CreatedList_AddToList_CheckIndexPosition()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            string firstValue = "4";
            string secondValue = "pie";
            string thirdValue = "star";
            string fourthValue = "light";
            string fifthValue = "ham";
            string expected = "ham";

            //act
            customList.Add(firstValue);
            customList.Add(secondValue);
            customList.Add(thirdValue);
            customList.Add(fourthValue);
            customList.Add(fifthValue);
            //assert
            Assert.AreEqual(expected, customList[4]);

        }
        [TestMethod]
        //UnitOfWork_SateUnderTest_ExpectedBehavior
        public void CreatedList_RemoveFromList_ValuesRemoved()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            string firstValue = "4";
            string secondValue = "6";
            int expected = 1;

            //act
            customList.Add(firstValue);
            customList.Add(secondValue);
            customList.Remove(firstValue);
            //assert
            Assert.AreEqual(expected, customList.count);
        }
        [TestMethod]
        public void CreatedList_RemoveFromList_CheckIndex()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            string firstValue = "4";
            string secondValue = "6";
            string expected = "6";

            //act
            customList.Add(firstValue);
            customList.Add(secondValue);
            customList.Remove(firstValue);
            //assert
            Assert.AreEqual(expected, customList[0]);

        }
        [TestMethod]
        public void CreatedList_RemoveFromList_CheckIndexDecrease()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            string firstValue = "4";
            string secondValue = "pie";
            string thirdValue = "star";
            string fourthValue = "light";
            string fifthValue = "ham";
            int expected = 4;

            //act
            customList.Add(firstValue);
            customList.Add(secondValue);
            customList.Add(thirdValue);
            customList.Add(fourthValue);
            customList.Add(fifthValue);
            customList.Remove(secondValue);
            //assert
            Assert.AreEqual(expected, customList.count);

        }
        [TestMethod]
        public void CreatedList_RemoveFromList_CheckIndexCapacity()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            string firstValue = "4";
            string secondValue = "pie";
            string thirdValue = "star";
            string fourthValue = "light";
            string fifthValue = "ham";
            int expected = 8;

            //act
            customList.Add(firstValue);
            customList.Add(secondValue);
            customList.Add(thirdValue);
            customList.Add(fourthValue);
            customList.Add(fifthValue);
            customList.Remove(firstValue);
            customList.Remove(secondValue);

            //assert
            Assert.AreEqual(expected, customList.capacity);

        }
        [TestMethod]
        public void CreatedList_RemoveFromList_CheckIndexPosition()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            string expected = "light";

            //act
            customList.Add("4");
            customList.Add("light");
            customList.Add("star");
            customList.Add("light");
            customList.Add("ham");
            customList.Remove("light");
            //assert
            Assert.AreEqual(expected, customList[2]);

        }
        [TestMethod]
        public void CreateCombinedString_StringIsCombined_CheckResult()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            string firstValue = "How";
            string secondValue = "are";
            string expected = "How are";
            
            //act
            customList.ToString(firstValue);
            customList.ToString(secondValue);
            //assert
            Assert.AreEqual(expected, customList[0]);
        }
        [TestMethod]
        public void CreateToString_Combined_CheckIndex1IsEmpty()
        {
            //arrange
            CustomList<string> customList = new CustomList<string>();
            string expected = null;
            //act
            customList.ToString("1");
            customList.ToString("2");
            //assert
            Assert.AreEqual(expected, customList[1]);
        }


    }
}
