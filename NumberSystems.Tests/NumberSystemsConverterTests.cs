using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace NumberSystems.Tests
{
    [TestClass]
    public class NumberSystemsConverterTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InputValue10NumberSystemMoreThan20()
        {
            int value = 10;
            int numSystem = 21;
            NumberSystemsConverter.ConvertFromIntTo(value, numSystem);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void InputValue10NumberSystemLessThan2()
        {
            int value = 10;
            int numSystem = 1;
            NumberSystemsConverter.ConvertFromIntTo(value, numSystem);
        }

        [TestMethod]
        public void RightConversionPositiveValueToHex()
        {
            int value = 255;
            int numSystem = 16;
            //Right conversion: FF
            Assert.AreEqual("FF", NumberSystemsConverter.ConvertFromIntTo(value, numSystem));
        }

        [TestMethod]
        public void RightConversionNegativeValueToHex()
        {
            int value = -255;
            int numSystem = 16;
            //Right conversion: -FF
            Assert.AreEqual("-FF", NumberSystemsConverter.ConvertFromIntTo(value, numSystem));
        }

        [TestMethod]
        public void RightConversionPositiveValueToBin()
        {
            int value = 15;
            int numSystem = 2;
            //Right conversion: 1111
            Assert.AreEqual("1111", NumberSystemsConverter.ConvertFromIntTo(value, numSystem));
        }

        [TestMethod]
        public void RightConversionPositiveValueTo20()
        {
            int value = 255;
            int numSystem = 20;
            //Right conversion: CF
            Assert.AreEqual("CF", NumberSystemsConverter.ConvertFromIntTo(value, numSystem));
        }


    }
}
