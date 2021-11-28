using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ArrayProcessingLib;

namespace SumTwoMinValueTestsLib
{
    [TestClass]
    public class CheckArrayTests
    {
        [TestMethod]
        public void TestArrayEmpty()
        {
            //arrange
            string[] array = { };
            string expected = "Array is empty";
            ;
            //act
            var calc = new ArrayСalculations();
            string actual = calc.SumTwoMinValues(array);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestArrayWithNonNumericValues()
        {
            //arrange
            string[] array = { "1,1", "2,2", "!", "4", "5,5" };
            string expected = "Some values cannot be processed";
            //act
            var calc = new ArrayСalculations();
            string actual = calc.SumTwoMinValues(array);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestArrayEmptyValues()
        {
            //arrange
            string[] array = { string.Empty, string.Empty, string.Empty, string.Empty, string.Empty };
            string expected = "Some values cannot be processed";
            //act
            var calc = new ArrayСalculations();
            string actual = calc.SumTwoMinValues(array);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
