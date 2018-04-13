using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class ConversionsTests
    {
        [TestMethod]
        public void TestGallonsFromLiters()
        {
            // arrange
            double liter = 1;
            double expected = .264172;

            // act
            var bus = new Converter.Conversions();
            var actual = bus.getGallonsFromLiters(liter);

            // assert
            Assert.AreEqual(expected, actual, 0.001, "Formulas are not equal");
        }

        [TestMethod]
        public void TestLitersFromGallons()
        {
            // arrange
            double gallon = 1;
            double expected = 3.78541;

            // act
            var bus = new Converter.Conversions();
            var actual = bus.getLitersFromGallons(gallon);

            // assert
            Assert.AreEqual(expected, actual, 0.001, "Formulas are not equal");
        }

        [TestMethod]
        public void TestPoundsFromKilograms()
        {
            // arrange
            double kilograms = 1;
            double expected = .453592;

            // act
            var bus = new Converter.Conversions();
            var actual = bus.getPoundsFromKilograms(kilograms);

            // assert
            Assert.AreEqual(expected, actual, 0.001, "Formulas are not equal");
        }

        [TestMethod]
        public void TestKilogramsFromPounds()
        {
            // arrange
            double pounds = 1;
            double expected = 2.20462;

            // act
            var bus = new Converter.Conversions();
            var actual = bus.getKilogramsFromPounds(pounds);

            // assert
            Assert.AreEqual(expected, actual, 0.001, "Formulas are not equal");
        }

        [TestMethod]
        public void TestFahrenheitFromCelcius()
        {
            // arrange
            double celcius = 0;
            double expected = 32;

            // act
            var bus = new Converter.Conversions();
            var actual = bus.getFahrenheitFromCelcius(celcius);

            // assert
            Assert.AreEqual(expected, actual, 0.001, "Formulas are not equal");
        }

        [TestMethod]
        public void TestCelciusFromFahrenheit()
        {
            // arrange
            double fahrenheit = 32;
            double expected = 0;

            // act
            var bus = new Converter.Conversions();
            var actual = bus.getCelciusFromFahrenheit(fahrenheit);

            // assert
            Assert.AreEqual(expected, actual, 0.001, "Formulas are not equal");
        }
    }
}
