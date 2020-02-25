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

        //public void CreatedList_AddToList_CheckIndexIncrease()
        //{
        //    //arrange
        //    CustomList<string> customList = new CustomList<string>();
        //    string firstValue = "4";
        //    string secondValue = "pie";
        //    string thirdValue = "star";
        //    string fourthValue = "light";
        //    string fifthValue = "ham";
        //    int expected = 8;

        //    //act
        //    customList.Add(firstValue);
        //    customList.Add(secondValue);
        //    customList.Add(thirdValue);
        //    customList.Add(fourthValue);
        //    customList.Add(fifthValue);
        //    //assert
        //    Assert.AreEqual(expected, customList.Capacity);

        //}

        //public void CreatedList_AddToList_CheckIndexCap4()
        //{
        //    //arrange
        //    CustomList<string> customList = new CustomList<string>();
        //    string firstValue = "4";
        //    string secondValue = "pie";
        //    string thirdValue = "star";
        //    int expected = 4;

        //    //act
        //    customList.Add(firstValue);
        //    customList.Add(secondValue);
        //    customList.Add(thirdValue);

        //    //assert
        //    Assert.AreEqual(expected, customList.Capacity);

        //}

        //public void CreatedList_AddToList_CheckIndexPosition()
        //{
        //    //arrange
        //    CustomList<string> customList = new CustomList<string>();
        //    string firstValue = "4";
        //    string secondValue = "pie";
        //    string thirdValue = "star";
        //    string fourthValue = "light";
        //    string fifthValue = "ham";
        //    string expected = "ham";

        //    //act
        //    customList.Add(firstValue);
        //    customList.Add(secondValue);
        //    customList.Add(thirdValue);
        //    customList.Add(fourthValue);
        //    customList.Add(fifthValue);
        //    //assert
        //    Assert.AreEqual(expected, customList[5]);

        //}
    }
}
