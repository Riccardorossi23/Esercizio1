using Esercizio1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TESTEsercizio1
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void Max1()
        {
            double max = Esercizio1MaxMinMed.Max(5, 2);
            Assert.AreEqual(max, 5);
        }
        [TestMethod]
        public void Minimo1()
        {
            double min = Esercizio1MaxMinMed.Min(5, 2);
            Assert.AreEqual(min, 2);
        }
        [TestMethod]
        public void Media1()
        {
            double med = Esercizio1MaxMinMed.Media(5, 2);
            Assert.AreEqual(med, 3.5);
        }
        [TestMethod]
        public void Max2()
        {
            double max2 = Esercizio1MaxMinMed.Max(3, 4);
            Assert.AreEqual(max2, 4);
        }
        [TestMethod]
        public void Minimo2()
        {
            double min2 = Esercizio1MaxMinMed.Min(3, 4);
            Assert.AreEqual(min2, 3);
        }
        [TestMethod]
        public void Media2()
        {
            double med2 = Esercizio1MaxMinMed.Media(3, 4);
            Assert.AreEqual(med2, 3.5);
        }
        [TestMethod]
        public void Max3()
        {
            double max3 = Esercizio1MaxMinMed.Max(7, 7);
            Assert.AreEqual(max3, 7);
        }
        [TestMethod]
        public void Minimo3()
        {
            double min3 = Esercizio1MaxMinMed.Min(7, 7);
            Assert.AreEqual(min3, 7);
        }
        [TestMethod]
        public void Media3()
        {
            double med3 = Esercizio1MaxMinMed.Media(7, 7);
            Assert.AreEqual(med3, 7);
        }
    }
}
