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
        public void AddToList()
        {
            //arrange
            CustomList customList = new CustomList()
            int firstValue = 4;
            int secondValue = 7;
            int expected = 47;
            int actual;
            //act
            actual = customList.AddToList(firstValue, secondValue);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
