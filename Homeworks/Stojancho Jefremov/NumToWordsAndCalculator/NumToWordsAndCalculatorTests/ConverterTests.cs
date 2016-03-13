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
        public void ToWordsEnglishTest()
        {
            Assert.AreEqual("One", Converter.ToWords(1, Language.English), "One");
            Assert.AreEqual("Two", Converter.ToWords(2, Language.English), "Two");
            Assert.AreEqual("Ten", Converter.ToWords(10, Language.English), "Ten");
            Assert.AreEqual("Eleven", Converter.ToWords(11, Language.English), "Eleven");
            Assert.AreEqual("Twenty one", Converter.ToWords(21, Language.English), "21");
            Assert.AreEqual("One hundred ninety two", Converter.ToWords(192, Language.English), "192");
            Assert.AreEqual("One thousand one hundred eighty seven", Converter.ToWords(1187, Language.English), "1187");
            Assert.AreEqual("Two thousand", Converter.ToWords(2000, Language.English), "2000");
            Assert.AreEqual("Twenty one thousand eleven", Converter.ToWords(21011, Language.English), "21011");
            Assert.AreEqual("One million", Converter.ToWords(1000000, Language.English), "Million");
            Assert.AreEqual("Twelve million three hundred forty one thousand six hundred seventy eight", Converter.ToWords(12341678, Language.English), "12341678");
            Assert.AreEqual("One hundred twenty eight billion three hundred forty one million nine hundred one", Converter.ToWords(128341000901, Language.English), "128341000901");
            Assert.AreEqual("One hundred twenty eight billion three hundred forty one million six hundred seventy nine thousand", Converter.ToWords(128341679000, Language.English), "128341679000");
            Assert.AreEqual("One hundred twenty eight billion three hundred forty one million six hundred seventy nine thousand nine hundred one", Converter.ToWords(128341679901, Language.English), "128341679901");
            Assert.AreEqual("Zero", Converter.ToWords(0, Language.English), "Zero");
            Assert.AreEqual("One billion one million one thousand one", Converter.ToWords(1001001001, Language.English), "1001001001");
        }

        [TestMethod()]
        public void ToWordsMacedonianTest()
        {
            Assert.AreEqual("Еден", Converter.ToWords(1, Language.Macedonian), "Еден");
            Assert.AreEqual("Два", Converter.ToWords(2, Language.Macedonian), "Два");
            Assert.AreEqual("Единаесет", Converter.ToWords(11, Language.Macedonian), "Единаесет");
            Assert.AreEqual("Дваесет и еден", Converter.ToWords(21, Language.Macedonian), "21");
            Assert.AreEqual("Сто деведесет и два", Converter.ToWords(192, Language.Macedonian), "192");
            Assert.AreEqual("Илјада сто осумдесет и седум", Converter.ToWords(1187, Language.Macedonian), "1187");
            Assert.AreEqual("Две илјади", Converter.ToWords(2000, Language.Macedonian), "2000");
            Assert.AreEqual("Дваесет и една илјада единаесет", Converter.ToWords(21011, Language.Macedonian), "21011");
            Assert.AreEqual("Дванаесет милиони триста четириесет и една илјада шестотини седумдесет и осум", Converter.ToWords(12341678, Language.Macedonian), "12341678");
            Assert.AreEqual("Сто дваесет и осум милијарди триста четириесет и еден милион шестотини седумдесет и девет илјади деветстотини и еден", Converter.ToWords(128341679901, Language.Macedonian), "128341679901");
        }
    }
}