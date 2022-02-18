using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Zlozenia;

namespace ProjektUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            bool wartosc = true
                ;

            //Act

            //Assert
            Assert.IsTrue(wartosc);
        } 

        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int zmienna = 25;
                

            //Act

            //Assert
            Assert.AreEqual(25,zmienna);
        } 
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            Karta karta = new Karta();
            karta = null;
                

            //Act

            //Assert
            Assert.IsNull(karta);
            
        }
        [TestMethod]
        public void OblicznieSredniej()
        {
            //Arrange
            Karta karta = new Karta();
            karta.DodajOcene(2);
            karta.DodajOcene(2);
            karta.DodajOcene(2);

            //Act

            //Assert
            Assert.AreEqual(2, karta.ObliczSrednia());
            
        }
    }
}
