using Microsoft.VisualStudio.TestTools.UnitTesting;
using Task2.Business_logic;
using System;
using System.Collections.Generic;
using System.Text;

namespace Task2.Business_logic.Tests
{
    [TestClass()]
    public class ServiceTests
    {
        [TestMethod()]
        public void howManyWordsTest()
        {
            //Arrange
            int expected = 3;
            string str = "oneTwoThree";

            //Act
            Service.howManyWords(str);

            //Assert
            int actual = Service.howManyWords(str);
            Assert.AreEqual(expected,actual);
        }
    }
}