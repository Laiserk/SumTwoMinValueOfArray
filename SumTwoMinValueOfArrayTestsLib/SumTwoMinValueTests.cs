using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ArrayProcessingLib;

namespace SumTwoMinValueOfArrayTestsLib
{
    [TestClass]
    public class SumTwoMinValueTests
    {

        [TestMethod]
        public void TestNonUniqueValues()
        {
            //arrange
            double[] array = {1.1, 1, 1.1, 2.2, 3, 3, 1, 4.4, 1, 5.5};
            double expected = 2;
            //act
            var calc = new ArrayÑalculations();
            double actual = calc.SumTwoMinValues(array);
            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestArrayWithNonNumericValues()
        {
            //arrange
            double[] array = { 1.1, 2.2, double.NaN, 4, 5.5 };
            double expected = 3.3;
            //act
            var calc = new ArrayÑalculations();
            double actual = Math.Round(calc.SumTwoMinValues(array), 4);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestArrayWithCharValues()
        {
            //arrange
            double[] array = { 1.1, 2.2, '!', 4, 5.5 };
            int expected = 3;
            //act
            var calc = new ArrayÑalculations();
            int actual = (int)calc.SumTwoMinValues(array);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestArrayWithIntValues()
        {
            //arrange
            double[] array = {1, 2, 3, 4, 5};
            int expected = 3;
            //act
            var calc = new ArrayÑalculations();
            int actual = (int)calc.SumTwoMinValues(array);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestArrayWithFloatValues()
        {
            //arrange
            double[] array = {1.1f, 2.2f, 3, 4, 5.5f};
            float expected = 3.3f;
            //act
            var calc = new ArrayÑalculations();
            float actual = (float)Math.Round(calc.SumTwoMinValues(array), 4);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestArrayWithDoubleValues()
        {
            //arrange
            double[] array = {1.1, 2.2, 3, 4, 5.5};
            double expected = 3.3;
            //act
            var calc = new ArrayÑalculations();
            double actual = Math.Round(calc.SumTwoMinValues(array), 4);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestArrayNegativeIntValues()
        {
            //arrange
            double[] array = {1, -2, 3, -4, 5};
            int expected = -6;
            //act
            var calc = new ArrayÑalculations();
            int actual = (int)calc.SumTwoMinValues(array);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestArrayNegativeFloatValues()
        {
            //arrange
            double[] array = { 1.1f, -2.2f, 3, -4, 5.5f };
            float expected = -6.2f;
            //act
            var calc = new ArrayÑalculations();
            float actual = (float)calc.SumTwoMinValues(array);
            //assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestArrayNegativeDoubleValues()
        {
            //arrange
            double[] array = { 1.1, -2.2, 3, -4, 5.5 };
            double expected = -6.2;
            //act
            var calc = new ArrayÑalculations();
            double actual = calc.SumTwoMinValues(array);
            //assert
            Assert.AreEqual(expected, actual);
        }
    }
}
