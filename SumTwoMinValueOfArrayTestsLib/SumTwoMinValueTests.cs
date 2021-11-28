using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ArrayProcessingLib;

namespace SumTwoMinValueTestsLib
{
    [TestClass]
    public class SumTwoMinValueTests
    {
        [TestMethod]
        public void TestNonUniqueValues()
        {
            //arrange
            string[] array = { "1,1", "1", "1,1", "2,2", "3", "3", "1", "4,4", "1", "5,5" };
            string expected = "2";
            //act
            var calc = new ArrayÑalculations();
            string actual = calc.SumTwoMinValues(array);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestArrayWithIntValues()
        {
            //arrange
            string[] array = { "1", "2", "3", "4", "5" };
            int expected = 3;
            //act
            var calc = new ArrayÑalculations();
            int actual = int.Parse(calc.SumTwoMinValues(array));
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestArrayWithFloatValues()
        {
            //arrange
            string[] array = { "1,1", "2,2", "3", "4", "5,5" };
            float expected = 3.3f;
            //act
            var calc = new ArrayÑalculations();
            float actual = float.Parse(calc.SumTwoMinValues(array));
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestArrayWithDoubleValues()
        {
            //arrange
            string[] array = { "1,1", "2,2", "3", "4", "5,5" };
            double expected = 3.3;
            //act
            var calc = new ArrayÑalculations();
            double actual = double.Parse(calc.SumTwoMinValues(array));
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestArrayNegativeIntValues()
        {
            //arrange
            string[] array = { "1", "-2", "3", "-4", "5" };
            int expected = -6;
            //act
            var calc = new ArrayÑalculations();
            int actual = int.Parse(calc.SumTwoMinValues(array));
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestArrayNegativeFloatValues()
        {
            //arrange
            string[] array = { "1,1", "-2,2", "3", "-4", "5,5" };
            float expected = -6.2f;
            //act
            var calc = new ArrayÑalculations();
            float actual = float.Parse(calc.SumTwoMinValues(array));
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestArrayNegativeDoubleValues()
        {
            //arrange
            string[] array = { "1,1", "-2,2", "3", "-4", "5,5" };
            double expected = -6.2;
            //act
            var calc = new ArrayÑalculations();
            double actual = double.Parse(calc.SumTwoMinValues(array));
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
