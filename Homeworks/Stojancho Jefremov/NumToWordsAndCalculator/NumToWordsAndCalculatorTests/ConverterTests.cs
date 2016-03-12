using Microsoft.VisualStudio.TestTools.UnitTesting;
using NumToWordsAndCalculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumToWordsAndCalculator.Tests
{
    [TestClass()]
    public class ConverterTests
    {
        [TestMethod()]
        public void ToWordsTest()
        {
            Assert.AreEqual("One", Converter.ToWords(1), "One");
            Assert.AreEqual("Two", Converter.ToWords(2), "Two");
            Assert.AreEqual("Ten", Converter.ToWords(10), "Ten");
            Assert.AreEqual("Eleven", Converter.ToWords(11), "Eleven");
            Assert.AreEqual("Twenty one", Converter.ToWords(21), "21");
            Assert.AreEqual("One hundred ninety two", Converter.ToWords(192), "192");
            Assert.AreEqual("One thousand one hundred eighty seven", Converter.ToWords(1187), "1187");
            Assert.AreEqual("Two thousand", Converter.ToWords(2000), "2000");
            Assert.AreEqual("Twenty one thousand eleven", Converter.ToWords(21011), "21011");
            Assert.AreEqual("One million", Converter.ToWords(1000000), "Million");
            Assert.AreEqual("Twelve million three hundred forty one thousand six hundred seventy eight", Converter.ToWords(12341678), "12341678");
            Assert.AreEqual("One hundred twenty eight billion three hundred forty one million nine hundred one", Converter.ToWords(128341000901), "128341000901");
            Assert.AreEqual("One hundred twenty eight billion three hundred forty one million six hundred seventy nine thousand", Converter.ToWords(128341679000), "128341679000");
            Assert.AreEqual("One hundred twenty eight billion three hundred forty one million six hundred seventy nine thousand nine hundred one", Converter.ToWords(128341679901), "128341679901");
            Assert.AreEqual("Zero", Converter.ToWords(0), "Zero");
            Assert.AreEqual("One billion one million one thousand one", Converter.ToWords(1001001001), "1001001001");
        }
    }
}